using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace DatabaseConnection
{
    class Program
    {
        public static void Main(string[] args)
        {
            GetByEnterpriseLibrary();
            GetByADONET();
            Console.Read();
        }

        private static void GetByADONET()
        {
            string connStr = "Server=DESKTOP-B32RQ3U;Database=Learning;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from EMP_MASTER", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("ID : "+dr["EmployeeID"]);
                    Console.WriteLine("EmployeeName : " + dr["EmployeeName"]);
                    Console.WriteLine("DepartmentID : " + dr["DepartmentID"]);
                }
                conn.Close();
            }
        }

        private static void GetByEnterpriseLibrary()
        {
            string connStr = "Server=DESKTOP-B32RQ3U;Database=Learning;Integrated Security=True;";
            SqlDatabase db = new SqlDatabase(connStr);
            DbCommand cmd = db.GetSqlStringCommand("SELECT * from EMP_MASTER");
            using (IDataReader reader = db.ExecuteReader(cmd))
            {
                while (reader.Read())
                {
                    Console.WriteLine("ID : " + reader["EmployeeID"].ToString());
                    Console.WriteLine("Name : " + reader["EmployeeName"].ToString());
                    Console.WriteLine("Department ID : " + reader["DepartmentID"].ToString());
                }
            }
        }
    }
}
