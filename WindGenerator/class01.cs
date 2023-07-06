using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;


namespace WindGenerator
{
    class DatabaseOperation
    {
        static SqlConnection conn;
        public static void connection()
        {
            String connetStr = "Data Source = LAPTOP - VEMPUMO4; Initial Catalog = 海上风电场; Integrated Security = True";
            conn = new SqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
