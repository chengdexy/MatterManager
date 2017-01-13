using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatterManagerClasses;
using DatabaseHelpers;
using System.Data.OleDb;

namespace MatterHelpers
{
    static class MatterHelper
    {
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

            //try
            //{
            //获取信息
            string title = mf.Title;
            string description = mf.Describe;
            DateTime beginDate = mf.BeginDate;
            MyStates state = mf.State;
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
            string sqlStr = string.Format("insert into tbMatter(title,description,beginDate,state,remind,fileNum,filePath) values('{0}','{1}','{2}','{3}',{4},'{5}','{6}')",
                title, description, beginDate.ToString(), state.ToString(), remind, fileNum, filePath);
            OleDbHelper.ExecuteInt(sqlStr);
            //TodoList
            InsertTodoList(todoList, thisMatterNumber);
            //HistoryList
            InsertHistoryList(historyList, thisMatterNumber);
            //Leadman
            SaveLeadman(leadman);
            //}
            //catch (Exception e)
            //{
            //    //插入失败,抛出异常
            //    //throw new Exception(e.Message);
            //    throw e;
            //}

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
                string state = list[i].State.ToString();
                string stop = list[i].StopDate.ToString();
                string stopRsn = list[i].StopReason;

                string sql = string.Format("insert into tbTodo(content,doneDate,doneDescription,state,stopDate,stopReason,mfNum) values('{0}','{1}','{2}','{3}','{4}','{5}',{6})",
                    content, done, doneDsp, state, stop, stopRsn, mfNum);
                OleDbHelper.ExecuteInt(sql);
            }
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
    }
}
