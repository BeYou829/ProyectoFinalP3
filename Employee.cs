using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalP3
{
    internal class Employee
    {
        static string connectionString = "Server=localhost;Database=winAppDB;Trusted_Connection=True;";
        public static DataTable ReportEmployee()
        {
            DataTable dt_employeeslist = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM employee", connection);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt_employeeslist);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt_employeeslist;
        }
    }
}
