using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using ADOX;
using System.Windows.Forms;

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

        public static int ExecuteInsert(string strSql, OleDbParameter[] parameters)
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
        public static int ExecuteScalar(string sql, OleDbParameter[] parameters)
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
        public static void ExecuteTrans(List<string> sqlList, List<OleDbParameter[]> paraList)
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
                        if (paraList != null && paraList[i] != null)
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
        public static DataSet ExecuteQuery(string sql, OleDbParameter[] parameters, string tableName)
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
                    da.Fill(ds, tableName);

                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
                return ds;
            }

        }

        public static DataSet ExecuteQuery(string sql,string tableName)
        {
            return ExecuteQuery(sql, null,tableName);
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

        /// <summary>
        /// 在access数据库中创建表
        /// </summary>
        /// <param name="filePath">数据库表文件全路径如D:\\NewDb.mdb 没有则创建 </param> 
        /// <param name="tableName">表名</param>
        /// <param name="colums">ADOX.Column对象数组</param>
        public static int CreateAccessTable(string tableName, params ADOX.Column[] colums)
        {
            try
            {
                ADOX.Catalog catalog = new Catalog();
                //数据库文件不存在则创建
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open(strConn, null, null, -1);
                catalog.ActiveConnection = cn;
                ADOX.Table table = new ADOX.Table();
                table.Name = tableName;
                foreach (var column in colums)
                {
                    table.Columns.Append(column);
                }
                // column.ParentCatalog = catalog; 
                //column.Properties["AutoIncrement"].Value = true; //设置自动增长
                //table.Keys.Append("FirstTablePrimaryKey", KeyTypeEnum.adKeyPrimary, column, null, null); //定义主键
                catalog.Tables.Append(table);
                int num = catalog.Tables.Count;
                cn.Close();
                return num;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
            return 0;
           
        }
        //========================================================================================调用
        //ADOX.Column[] columns = {
        //                     new ADOX.Column(){Name="id",Type=DataTypeEnum.adInteger,DefinedSize=9},
        //                     new ADOX.Column(){Name="col1",Type=DataTypeEnum.adWChar,DefinedSize=50},
        //                     new ADOX.Column(){Name="col2",Type=DataTypeEnum.adLongVarChar,DefinedSize=50}
        //                 };
        // AccessDbHelper.CreateAccessTable("d:\\111.mdb", "testTable", columns);
    }
}
