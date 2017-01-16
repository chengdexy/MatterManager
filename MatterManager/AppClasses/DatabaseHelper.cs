using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace DatabaseHelpers
{
    static class OleDbHelper
    {
        private static OleDbConnection cnn = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string myConnectionString = ConfigurationManager.ConnectionStrings["conn"].ToString();

        /// <summary>
        /// 获得并打开一个数据库连接
        /// </summary>
        /// <returns>数据库连接对象</returns>
        private static void openCnn()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.ConnectionString = myConnectionString;
                cmd.Connection = cnn;
                try
                {
                    cnn.Open();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        /// <summary>
        /// 关闭并销毁一个数据库连接
        /// </summary>
        /// <param name="cnn">要关闭销毁的OleDbConnection对象</param>
        private static void closeCnn()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
            }
        }
        /// <summary>
        /// 执行一条sql语句,返回受影响的记录数
        /// 通常用于执行无需返回具体数据的操作
        /// 如insert/delete/update
        /// </summary>
        /// <param name="sqlStr">sql语句字符串</param>
        /// <returns>受影响的记录数</returns>
        public static int ExecuteInt(string sqlStr)
        {
            try
            {
                openCnn();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeCnn();
            }
        }
        /// <summary>
        /// 执行一条sql查询,将查询结果记录集返回
        /// </summary>
        /// <param name="sqlStr">sql语句字符串</param>
        /// <returns>OleDbDataReader对象</returns>
        public static OleDbDataReader ExecuteReader(string sqlStr)
        {
            OleDbDataReader dr = null;
            //try
            //{
                openCnn();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //}
            //catch
            //{
            //    try
            //    {
            //        dr.Close();
            //        closeCnn();
            //    }
            //    catch (Exception e)
            //    {
            //        throw new Exception(e.Message);
            //    }
            //}
            return dr;
        }
        /// <summary>
        /// 执行一条sql统计查询,将查询结果第1行第1列的内容返回
        /// </summary>
        /// <param name="sqlStr">sql语句字符串</param>
        /// <returns>object对象,查询结果的第1行第1列的内容</returns>
        public static object ExecuteScaler(string sqlStr)
        {
            try
            {
                openCnn();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeCnn();
            }
        }
    }
}
