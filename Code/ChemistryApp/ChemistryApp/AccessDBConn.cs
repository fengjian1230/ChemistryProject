using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace ChemistryApp
{
    /// <summary>
    /// access数据库连接
    /// </summary>
    class AccessDBConn
    {
        public static string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ChemistryDB.accdb;Persist Security Info=False";

        public AccessDBConn()
        {

        }

        public static int ExecuteInsert(string strSql,OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                OleDbCommand cmd = new OleDbCommand(strSql, conn);
                try
                {
                    conn.Open();
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = @"select @@identity";
                        int value = Int32.Parse(cmd.ExecuteScalar().ToString());
                        return value;
                    }
                }
                catch (Exception e)
                {

                    throw e;
                }
                return -1;
            }
        }

        /// <summary>
        /// 执行不带参数的sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteInsert(string sql)
        {
            return ExecuteInsert(sql, null);
        }

        //执行带参数的sql语句,返回影响的记录数（insert,update,delete)
        public static int ExecuteNonQuery(string sql, OleDbParameter[] parameters)
        {
            //Debug.WriteLine(sql);
            using (OleDbConnection connection = new OleDbConnection(strConn))
            {
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                try
                {
                    connection.Open();
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //执行不带参数的sql语句，返回影响的记录数
        //不建议使用拼出来SQL
        public static int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, null);
        }


        /// <summary>
        /// 执行单挑语句返回第一行第一列，可以用来返回contun
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static int ExecuteScalar(string sql,OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(strConn))
            {
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                try
                {
                    connection.Open();
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    int value = int.Parse(cmd.ExecuteScalar().ToString());
                    return value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static int ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, null);
        }

        /// <summary>
        /// 执行事物
        /// </summary>
        /// <param name="sqlList"></param>
        /// <param name="paraList"></param>
        public static void ExecuteTrans(List<string> sqlList,List<OleDbParameter[]> paraList)
        {
            using (OleDbConnection connection = new OleDbConnection(strConn))
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbTransaction transaction = null;
                cmd.Connection = connection;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    cmd.Transaction = transaction;

                    for (int i = 0; i < sqlList.Count; i++)
                    {
                        cmd.CommandText = sqlList[i];
                        if (paraList !=null && paraList[i] != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(paraList[i]);
                        }
                        transaction.Commit();
                    }
                }
                catch (Exception e)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    throw e;
                }

            }
        }
        public static void ExecuteTrans(List<string> sqlList)
        {
            ExecuteTrans(sqlList, null);
        }

        /// <summary>
        /// 执行查询语句，返回dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet ExecuteQuery(string sql,OleDbParameter[] parameters)
        {
            
            using (OleDbConnection connection = new OleDbConnection(strConn))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, strConn);
                    if (parameters != null)
                    {
                        da.SelectCommand.Parameters.AddRange(parameters);
                    }
                    da.Fill(ds, "LessonList");

                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
                return ds;
            }
            
        }

        public static DataSet ExecuteQuery(string sql)
        {
            return ExecuteQuery(sql, null);
        }

        /// <summary>
        /// 执行查询语句返回datareader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string sql)
        {
            OleDbConnection conntection = new OleDbConnection(strConn);
            OleDbCommand cmd = new OleDbCommand(sql, conntection);
            try
            {
                conntection.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                conntection.Close();
                throw e;
            }
        }


    }
}
