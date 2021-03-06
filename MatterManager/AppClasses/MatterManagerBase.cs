﻿using System;
using System.Collections.Generic;
using System.IO;

namespace MatterManagerClasses
{
    /// <summary>
    /// 枚举类型MyStates,用于标识matter及todoitem的执行状态
    /// </summary>
    enum MyStates
    {
        办理中 = 0,
        已办结 = 1,
        已中止 = 2,
    };
    /// <summary>
    /// 事务类基类
    /// </summary>
    class Matter
    {
        #region 字段&属性
        //事项编号
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        //事项名称
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }
        //事项描述
        private string _describe;
        public string Describe
        {
            get
            {
                return _describe;
            }

            set
            {
                _describe = value;
            }
        }
        //发生时间
        private DateTime _beginDate;
        public DateTime BeginDate
        {
            get
            {
                return _beginDate;
            }

            set
            {
                _beginDate = value;
            }
        }
        //进度状态
        private MyStates _state;
        public MyStates State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }
        //牵头人
        private Leadman _leader;
        internal Leadman Leader
        {
            get
            {
                return _leader;
            }

            set
            {
                _leader = value;
            }
        }

        //提醒间隔
        private int _howManyHoursToRemind;
        public int HowManyHoursToRemind
        {
            get
            {
                return _howManyHoursToRemind;
            }

            set
            {
                _howManyHoursToRemind = value;
            }
        }


        //待办内容
        private List<TodoItem> _todoItemList;
        internal List<TodoItem> TodoItemList
        {
            get
            {
                return _todoItemList;
            }

            set
            {
                _todoItemList = value;
            }
        }

        //督办记录
        private List<SuperviseRecord> _historyRecord;
        internal List<SuperviseRecord> HistoryRecord
        {
            get
            {
                return _historyRecord;
            }

            set
            {
                _historyRecord = value;
            }
        }

        //事件类型
        private string _kind;
        public string Kind
        {
            get
            {
                return _kind;
            }

            set
            {
                _kind = value;
            }
        }
        #endregion

        #region 构造函数
        public Matter()
        {
            BeginDate = DateTime.Today;
            State = MyStates.办理中;
            TodoItemList = new List<TodoItem>();
            HistoryRecord = new List<SuperviseRecord>();
            HowManyHoursToRemind = 24;
        }
        public Matter(string title, Leadman leadman)
        {
            Title = title;
            BeginDate = DateTime.Today ;
            State = MyStates.办理中;
            TodoItemList = new List<TodoItem>();
            HistoryRecord = new List<SuperviseRecord>();
            HowManyHoursToRemind = 24;
            Leader = leadman;
        }
        #endregion
    }
    /// <summary>
    /// 事务类:文件
    /// </summary>
    class matterFiles : Matter
    {
        //文号
        private string _fileNum;
        public string FileNum
        {
            get
            {
                return _fileNum;
            }

            set
            {
                _fileNum = value;
            }
        }
        //存放地址
        private string _fileAddr;
        public string FileAddr
        {
            get
            {
                return _fileAddr;
            }

            set
            {
                _fileAddr = value;
            }
        }

        //构造函数
        public matterFiles() : base()
        {

        }
        public matterFiles(string title, Leadman leadman, string fileNum) : base(title, leadman)
        {
            Kind = "文件";
            FileNum = fileNum;
            Leader = leadman;
        }

        //方法
        //上传文件
        public void uploadFile(string sourcePath, string targetPath)
        {
            //从sourcePath复制到targetPath
            if (string.Equals(sourcePath, targetPath))
            {
                //编辑模式未修改文件
                FileAddr = targetPath;
                return;
            }
            try
            {
                File.Copy(sourcePath, targetPath, true);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //保存存储地址
            FileAddr = targetPath;
        }

        //下载文件
        public void downloadFile(string targetPath)
        {
            if (!String.IsNullOrEmpty(FileAddr))
            {
                //判断文件是否存在,存在则继续
                if (File.Exists(FileAddr))
                {
                    //从FileAddr复制到targetPath
                    try
                    {
                        File.Copy(FileAddr, targetPath);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    //保存的文件没有了
                    throw new Exception("文件不存在!");
                }
            }
            else
            {
                throw new Exception("此文件尚未上传过,调用download失败");
            }
        }

        //删除文件
        public bool deleteFile()
        {
            if (!String.IsNullOrEmpty(FileAddr))
            {
                //判断文件是否存在,存在则继续
                if (File.Exists(FileAddr))
                {
                    try
                    {
                        //删除FileAddr所指文件
                        File.Delete(FileAddr);
                        //删除成功完成
                        FileAddr = String.Empty;
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    //文件不存在,无需删除
                    return true;
                }
            }
            else
            {
                //文件不存在
                return true;
            }
        }
    }
    /// <summary>
    /// 牵头人类
    /// </summary>
    class Leadman
    {
        /// <summary>
        /// 数据库中对应id号
        /// </summary>
        private int _id;
        /// <summary>
        /// 数据库中对应id号
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


        /// <summary>
        /// 牵头人职务
        /// </summary>
        private string _itsPost;
        /// <summary>
        /// 牵头人职务
        /// </summary>
        public string ItsPost
        {
            get
            {
                return _itsPost;
            }

            set
            {
                _itsPost = value;
            }
        }




        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">牵头人姓名</param>
        public Leadman(string name)
        {
            Name = name;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">牵头人姓名</param>
        /// <param name="itsPost">牵头人职务</param>
        public Leadman(string name, string itsPost)
        {
            Name = name;
            ItsPost = itsPost;
        }
    }
    /// <summary>
    /// 待办项目类
    /// </summary>
    class TodoItem
    {
        /// <summary>
        /// 数据库中的id号
        /// </summary>
        private int _id;
        /// <summary>
        /// 数据库中的id号
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// 项目进度
        /// </summary>
        private MyStates _state;
        /// <summary>
        /// 项目进度
        /// </summary>
        internal MyStates State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        /// <summary>
        /// 项目内容
        /// </summary>
        private string _content;
        /// <summary>
        /// 项目内容
        /// </summary>
        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        /// <summary>
        /// 办结日期
        /// </summary>
        private DateTime _doneDate;
        public DateTime DoneDate
        {
            get
            {
                return _doneDate;
            }

            set
            {
                _doneDate = value;
            }
        }

        /// <summary>
        /// 办结描述
        /// </summary>
        private string _doneDescription;
        /// <summary>
        /// 办结描述
        /// </summary>
        public string DoneDescription
        {
            get
            {
                return _doneDescription;
            }

            set
            {
                _doneDescription = value;
            }
        }

        /// <summary>
        /// 中止日期
        /// </summary>
        private DateTime _stopDate;
        /// <summary>
        /// 中止日期
        /// </summary>
        public DateTime StopDate
        {
            get
            {
                return _stopDate;
            }

            set
            {
                _stopDate = value;
            }
        }


        /// <summary>
        /// 中止原因
        /// </summary>
        private string _stopReason;
        /// <summary>
        /// 中止原因
        /// </summary>
        public string StopReason
        {
            get
            {
                return _stopReason;
            }

            set
            {
                _stopReason = value;
            }
        }







        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="content">项目内容</param>
        public TodoItem(string content)
        {
            Content = content;
            State = MyStates.办理中;
        }

        //方法
        public void setItemDone(string doneDescription)
        {
            State = MyStates.已办结;
            DoneDate = DateTime.Today ;
            DoneDescription = doneDescription;
        }
        public void setItemStop(string stopReason)
        {
            State = MyStates.已中止;
            StopDate = DateTime.Today ;
            StopReason = stopReason;
        }
    }
    /// <summary>
    /// 督办记录类
    /// </summary>
    class SuperviseRecord
    {
        /// <summary>
        /// 数据库中id值
        /// </summary>
        private int _id;
        /// <summary>
        /// 数据库中id值
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// 联系日期
        /// </summary>
        private DateTime _connectDate;
        /// <summary>
        /// 联系日期
        /// </summary>
        public DateTime ConnectDate
        {
            get
            {
                return _connectDate;
            }

            set
            {
                _connectDate = value;
            }
        }


        /// <summary>
        /// 反馈结果
        /// </summary>
        private string _result;
        /// <summary>
        /// 反馈结果
        /// </summary>
        public string Result
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
            }
        }




        //构造函数
        public SuperviseRecord(DateTime connectDate, string result)
        {
            ConnectDate = connectDate;
            Result = result;
        }
    }
}
