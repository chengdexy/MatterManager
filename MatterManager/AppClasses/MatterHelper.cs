using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatterManagerClasses;
using DatabaseHelpers;
using System.Data.OleDb;
using System.IO;

namespace MatterHelpers
{
    static class MatterHelper
    {
        public static DateTime defaultDate = DateTime.MinValue;

        #region Matters

        public static string DeleteMatter(matterFiles mf)
        {
            string result = "删除成功完成!";
            //检查todolist是否包含未办结项目
            List<TodoItem> todoList = mf.TodoItemList;
            if (todoList.Count != getCountNotDoingFromTodoList(todoList))
            {
                result = "这件督办事务中包含正在进行中的待办事项,无法删除!";
                return result;
            }
            try
            {
                //删除数据库中相关todoitem
                DeleteTodoList(mf.Id);
                //删除数据库中相关history
                DeleteHistoryList(mf.Id);
                //删除对应文件
                mf.deleteFile();
                //删除数据库中此matter数据
                string sql = "delete from tbMatter where id=" + mf.Id;
                OleDbHelper.ExecuteInt(sql);
            }
            catch
            {
                result = "删除失败,请检查数据库连接状况及相关文件是否被占用.";
                return result;
            }
            //返回删除任务执行结果
            return result;
        }

        /// <summary>
        /// 获取数据库中所有的matter信息
        /// </summary>
        /// <returns>数据库中所有的matter信息列表</returns>
        public static List<matterFiles> getAllMatters()
        {
            OleDbDataReader dr = null;
            List<matterFiles> list = new List<matterFiles>();
            string sqlstr = "select * from tbMatter";
            dr = OleDbHelper.ExecuteReader(sqlstr);
            while (dr.Read())
            {
                matterFiles mf = new matterFiles();
                mf.Id = Convert.ToInt32(dr["id"]);
                mf.Title = dr["title"].ToString();
                mf.Describe = dr["description"].ToString();
                mf.BeginDate = Convert.ToDateTime(dr["beginDate"]);
                mf.State = (MyStates)Convert.ToInt32(dr["state"]);
                mf.HowManyHoursToRemind = Convert.ToInt32(dr["remind"]);
                mf.FileNum = dr["fileNum"].ToString();
                mf.FileAddr = dr["filePath"].ToString();
                mf.Leader = new Leadman(dr["leadername"].ToString(), dr["leaderpost"].ToString());
                list.Add(mf);
            }
            dr.Close();
            for (int i = 0; i < list.Count; i++)
            {
                matterFiles mf = list[i];
                mf.TodoItemList = getTodoList(mf.Id);
                mf.HistoryRecord = getHistoryList(mf.Id);
            }
            return list;
        }

        /// <summary>
        /// 向数据库中插入一条新的Matter记录
        /// 包括基本信息/TodoList/HistoryList/新的Leadman
        /// </summary>
        /// <param name="mf">要插入的Matter对象</param>
        public static void InsertMatter(matterFiles mf)
        {
            /*将一个Matter对象保存至数据库中的步骤为:
             * 1. 判断Matter类型,如果是File类型有额外操作
             * 2. 将基本信息插入Matter表
             * 3. 将TodoItemList插入TodoList表
             * 4. 将HistoryList插入History表
             * 5. 将Leadman插入Leadman表(如果已存在,则不执行)
             * 6. 如果是File类,多存一个文号,和一个文件存放Path
             */

            try
            {
                //获取信息
                string title = mf.Title;
                string description = mf.Describe;
                DateTime beginDate = mf.BeginDate;
                int state = Convert.ToInt32(mf.State);
                Leadman leadman = mf.Leader;
                int remind = mf.HowManyHoursToRemind;
                List<TodoItem> todoList = mf.TodoItemList;
                List<SuperviseRecord> historyList = mf.HistoryRecord;
                string fileNum = mf.FileNum;
                string filePath = mf.FileAddr;
                int thisMatterNumber;
                object obj = OleDbHelper.ExecuteScaler("select max(id) from tbMatter");
                if (obj != DBNull.Value)
                {
                    thisMatterNumber = Convert.ToInt32(obj) + 1;
                }
                else
                {
                    thisMatterNumber = 1;
                }
                //分别插入数据库中
                //基本信息
                string sqlStr = string.Format("insert into tbMatter(title,description,beginDate,state,remind,fileNum,filePath,leadername,leaderpost) values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}')",
                    title, description, beginDate.ToString(), state.ToString(), remind, fileNum, filePath, leadman.Name, leadman.ItsPost);
                OleDbHelper.ExecuteInt(sqlStr);
                //TodoList
                InsertTodoList(todoList, thisMatterNumber);
                //HistoryList
                InsertHistoryList(historyList, thisMatterNumber);
                //Leadman
                SaveLeadman(leadman);
            }
            catch (Exception e)
            {
                //插入失败,抛出异常
                //throw new Exception(e.Message);
                throw e;
            }

        }



        #endregion

        #region TodoItems
        /// <summary>
        /// 获取指定id号的Matter所对应的TodoList
        /// </summary>
        /// <param name="id">Matter的id编号</param>
        /// <returns>id所对应的TodoList</returns>
        public static List<TodoItem> getTodoList(int id)
        {
            OleDbDataReader dr = null;
            List<TodoItem> list = new List<TodoItem>();
            string sqlStr = "select * from tbTodo where mfNum=" + id;
            dr = OleDbHelper.ExecuteReader(sqlStr);
            while (dr.Read())
            {
                TodoItem ti = new TodoItem(dr["content"].ToString());
                ti.DoneDate = Convert.ToDateTime(dr["doneDate"]);
                ti.DoneDescription = dr["doneDescription"].ToString();
                ti.State = (MyStates)(Convert.ToInt32(dr["state"]));
                ti.StopDate = Convert.ToDateTime(dr["stopDate"]);
                ti.StopReason = dr["stopReason"].ToString();
                list.Add(ti);
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 将一个TodoList存入数据库中的tbTodo中
        /// </summary>
        /// <param name="list">要存的TodoItemsList对象</param>
        /// <param name="mfNum">TodoList所属的Matter编号(数据库中的id字段)</param>
        public static void InsertTodoList(List<TodoItem> list, int mfNum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string content = list[i].Content;
                string done = list[i].DoneDate.ToString();
                string doneDsp = list[i].DoneDescription;
                string state = Convert.ToInt32(list[i].State).ToString();
                string stop = list[i].StopDate.ToString();
                string stopRsn = list[i].StopReason;

                string sql = string.Format("insert into tbTodo(content,doneDate,doneDescription,state,stopDate,stopReason,mfNum) values('{0}','{1}','{2}','{3}','{4}','{5}',{6})",
                    content, done, doneDsp, state, stop, stopRsn, mfNum);
                OleDbHelper.ExecuteInt(sql);
            }
        }
        /// <summary>
        /// 获取指定TodoList中不在办理中的项目个数
        /// </summary>
        /// <param name="list">指定的TodoList</param>
        /// <returns>办结数+中止数</returns>
        public static int getCountNotDoingFromTodoList(List<TodoItem> list)
        {
            int doneCount = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].State != MyStates.办理中)
                {
                    doneCount++;
                }
            }
            return doneCount;
        }
        /// <summary>
        /// 从数据库中删除指定id的matter所包含的todolist信息
        /// </summary>
        /// <param name="mfNum">待操作的matter的id</param>
        public static void DeleteTodoList(int mfNum)
        {
            try
            {
                string sql = "delete from tbTodo where mfNum=" + mfNum;
                OleDbHelper.ExecuteInt(sql);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        #endregion

        #region HistoryList
        /// <summary>
        /// 获取指定id的Matter对应的所有SuperviseRecord
        /// </summary>
        /// <param name="id">指定的id</param>
        /// <returns>HistoryList</returns>
        public static List<SuperviseRecord> getHistoryList(int id)
        {
            OleDbDataReader dr = null;
            List<SuperviseRecord> list = new List<SuperviseRecord>();
            string sqlStr = "select * from tbHistory where mfNum=" + id;
            dr = OleDbHelper.ExecuteReader(sqlStr);
            while (dr.Read())
            {
                DateTime connect = Convert.ToDateTime(dr["connect"]);
                string result = dr["result"].ToString();
                SuperviseRecord sr = new SuperviseRecord(connect, result);
                list.Add(sr);
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 将一个HistoryList存入数据库中的tbHistory中
        /// </summary>
        /// <param name="list">要存的HistoryList对象</param>
        /// <param name="mfNum">HistoryList所属的Matter编号(数据库中的id字段)</param>
        public static void InsertHistoryList(List<SuperviseRecord> list, int mfNum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string connect = list[i].ConnectDate.ToString();
                string result = list[i].Result;

                string sql = string.Format("insert into tbHistory(connect,result,mfNum) values('{0}','{1}',{2})", connect, result, mfNum);
                OleDbHelper.ExecuteInt(sql);
            }
        }
        /// <summary>
        /// 从数据库中删除指定id的matter所包含的historylist
        /// </summary>
        /// <param name="mfNum">待操作的matter的id</param>
        public static void DeleteHistoryList(int mfNum)
        {
            try
            {
                string sql = "delete from tbHistory where mfNum=" + mfNum;
                OleDbHelper.ExecuteInt(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        #endregion

        #region Leadmans
        /// <summary>
        /// 从数据库中获取所有已存在的Leadman对象信息,供UI层使用
        /// </summary>
        /// <returns>Leadman对象列表</returns>
        public static List<Leadman> getAllLeadmans()
        {
            string sqlStr = "select * from tbLeadman";
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sqlStr);
            List<Leadman> leaderList = new List<Leadman>();
            Leadman leader;
            while (dr.Read())
            {
                leader = new Leadman(dr["name"].ToString(), dr["itspost"].ToString());
                leaderList.Add(leader);
            }
            dr.Close();
            return leaderList;
        }

        /// <summary>
        /// 判断数据库中是否已经存在一个一模一样的Leadman数据
        /// </summary>
        /// <param name="leader">要判断是否存在的Leadman对象</param>
        /// <returns>true:已存在,false不存在</returns>
        public static bool IsExist(Leadman leader)
        {
            try
            {
                string name = leader.Name;
                string post = leader.ItsPost;
                string sql = "select count(*) from tbLeadman where name='" + name + "' and itspost='" + post + "'";
                int count = Convert.ToInt32(OleDbHelper.ExecuteScaler(sql));
                if (count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// 将一个Leadman对象存入数据库
        /// </summary>
        /// <param name="leader">要存入数据库的Leadman对象</param>
        public static void SaveLeadman(Leadman leader)
        {
            try
            {
                if (!IsExist(leader))
                {
                    string name = leader.Name;
                    string post = leader.ItsPost;
                    string sql = "insert into tbLeadman(name,itspost) values('" + name + "','" + post + "')";
                    OleDbHelper.ExecuteInt(sql);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// 删除一个Leadman
        /// </summary>
        /// <param name="leader">要删除的leadman对象</param>
        public static void DeleteLeadman(Leadman leader)
        {
            try
            {
                if (IsExist(leader))
                {
                    string name = leader.Name;
                    string post = leader.ItsPost;
                    string sql = "delete from tbLeadman where name='" + name + "' and itspost='" + post + "'";
                    OleDbHelper.ExecuteInt(sql);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion
    }
}
