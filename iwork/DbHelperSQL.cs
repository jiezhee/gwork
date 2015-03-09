using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBUtility
{
    /// <summary>
    /// 数据访问抽象基础类
    /// </summary>
    public abstract class DbHelperSQL
    {
        public static string connectionString = PubConstant.ConnectionString;

        public DbHelperSQL()
        {
        }

        #region  执行简单SQL语句

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        MessageBox.Show("错误");
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSQL)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            try
            {
                connection.Open();
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }



        /// <summary>
        /// 执行查询语句，载入信息到combobox ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>void</returns>
        public static void ExecuteReader_combobox(string strSQL,ComboBox c)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            try
            {
                connection.Open();
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
 
                 while(myReader.Read())
              {
                  c.Items.Add(myReader[0]);
              }
                 connection.Close();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }



        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                  
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    connection.Close();
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

        /// <summary>
        /// 执行查询语句，返回查询列最大值
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>int</returns>
        public static int maxnum(string column,string table)
        {
            string sql = "select (case when MAX("+column+") is null then 0 else MAX("+column +") end) as MAXID from "+table;
          //  MessageBox.Show(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return(int.Parse(cmd.ExecuteScalar().ToString()));
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }


        /// <summary>
        /// 执行查询语句，返回时间列最近时间的天值
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>int</returns>
        public static int lastday(string column, string table)
        {
            string sql = "select day("+column+") from "+table+" where "+column+" =( select(case when MAX(" + column + ") is null then 0 else MAX(" + column + ") end) from " + table+")";
            //  MessageBox.Show(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                int day=0;
                connection.Open();
                if(cmd.ExecuteScalar()!=null)
                {
                day=int.Parse(cmd.ExecuteScalar().ToString());//返回查询结果第一行、第一列
                }
                return day;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }


        /// <summary>
        /// 执行查询语句，返回时间列最近时间的天的最后一张订单的序号
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>int</returns>
        public static int lastday_purnum()
        {
            string sql = "select 采购单序号 from 采购信息 where 日期 =(select(case when MAX(日期) is null then 0 else MAX(日期) end) from 采购信息)";
           // MessageBox.Show(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                int num=0;
                if (cmd.ExecuteScalar() != null)
                {
                    num = int.Parse(cmd.ExecuteScalar().ToString());//返回查询结果第一行、第一列
                }
                return num;//返回查询结果第一行、第一列
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }



        /// <summary>
        /// 执行查询语句，返回查询字符串是否在数据库某列中
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>bool</returns>
        public static bool isin(string ss,string column,string table)
        {
            string sql = "select(case when '"+ss+"' in (select "+column+" from "+table+") then 1 else 0 end)";
          //   MessageBox.Show(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                    if (int.Parse(cmd.ExecuteScalar().ToString()) == 1)
                    {
                        return true;
                    }
                    return false;
             
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }


        /// <summary>
        /// 执行查询语句，返回查询第一行第一列的值
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>bool</returns>
        public static string execscalar(string sql)
        {
           
            //   MessageBox.Show(sql);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                if (cmd.ExecuteScalar() != null)
                {
                    return cmd.ExecuteScalar().ToString();
                }
                else
                {
                    return null;
                }

            }
            catch (System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                MessageBox.Show("错误");
                throw e;
            }

        }

/*
        /// <summary>
        /// 更新物料库存=可用库存+即将需要(type=1为添加，=0为减少)
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>总库存</returns>
        public static int Store(string wuliaoNO,int change,int type)
        {
                int a = int.Parse(execscalar("select 可用库存 from 库存信息 where 物料NO='" + wuliaoNO + "'"));
                int b = int.Parse(execscalar("select 即将需要 from 库存信息 where 物料NO='" + wuliaoNO + "'"));
                int c;
            string sql=string.Empty;
            if (type == 1)
            {
                //add 
                c = a + change;
                sql = "update 库存信息 set 可用库存='";  
                sql += c.ToString() + "' where 物料NO='" + wuliaoNO + "'";
                ExecuteSql(sql);

                c=a+change+b;
                sql = "update 库存信息 set 库存='";  
                sql += c.ToString() + "' where 物料NO='" + wuliaoNO + "'";
                ExecuteSql(sql);

            }
            else
                if (type == 0)
                {
                    //minus
                    if (a < change)
                    {
                        MessageBox.Show("出库量不能小于库存");
                    }
                }
                    

        }
        */

        #endregion
    }
}


