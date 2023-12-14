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

        public static bool SaveEmployee(
            string fname, string lname, string sex, string docid,
            string dob, string email, string phonenumber, string altphonenumber,
            string direccion, string ciudad, string provincia, string rol, string departamento)
        {
            bool pass = false;

            DataTable dt_employeeslist = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO employee (fname, lname, sex, docid, DOB, email, phonenumber, altphonenumber, direccion, ciudad, provincia, rol, departamento) VALUES (@fname ,@lname, @sex, @docid, @DOB, @email, @phonenumber, @altphonenumber, @direccion, @ciudad, @provincia, @rol, @departamento)", connection);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@docid", docid);
            command.Parameters.AddWithValue("@DOB", dob);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phonenumber", phonenumber);
            command.Parameters.AddWithValue("@altphonenumber", altphonenumber);
            command.Parameters.AddWithValue("@direccion", direccion);
            command.Parameters.AddWithValue("@ciudad", ciudad);
            command.Parameters.AddWithValue("@provincia", provincia);
            command.Parameters.AddWithValue("@rol", rol);
            command.Parameters.AddWithValue("@departamento", departamento);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                pass = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }

            return pass;
        }
        public static bool UpdateEmployee(
            string fname, string lname, string sex, string docid,
            string dob, string email, string phonenumber, string altphonenumber,
            string direccion, string ciudad, string provincia, string rol, string departamento, string ID)
        {
            bool pass = false;

            DataTable dt_employeeslist = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("UPDATE employee SET fname = @fname," +
                " lname = @lname," +
                " sex = @sex," +
                " docid = @docid," +
                " DOB = @DOB," +
                " email = @email," +
                " phonenumber = @phonenumber," +
                " altphonenumber = @altphonenumber," +
                " direccion = @direccion ," +
                " ciudad = @ciudad," +
                " provincia = @provincia," +
                " rol = @rol," +
                " departamento = @departamento WHERE Id = @ID" , connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@docid", docid);
            command.Parameters.AddWithValue("@DOB", dob);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phonenumber", phonenumber);
            command.Parameters.AddWithValue("@altphonenumber", altphonenumber);
            command.Parameters.AddWithValue("@direccion", direccion);
            command.Parameters.AddWithValue("@ciudad", ciudad);
            command.Parameters.AddWithValue("@provincia", provincia);
            command.Parameters.AddWithValue("@rol", rol);
            command.Parameters.AddWithValue("@departamento", departamento);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                pass = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return pass;
        }

        //    public static bool UpdateEmploye(
        //        string id, string fname, string lname, string sex, string docid,
        //        string dob, string email, string phonenumber, string altphonenumber,
        //        string direccion, string ciudad, string provincia, string rol, string departamento)
        //    {
        //        bool pass = false;

        //        DataTable dt_employeeslist = new DataTable();
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        SqlCommand command = new SqlCommand("UPDATE employee SET " +
        //            "fname = @fname" +
        //            "lname = @lname" +
        //            "sex = @sex" +
        //            "docid = @docid" +
        //            "DOB = @DOB" +
        //            "email = @email" +
        //            "phonenumber = @phonenumber" +
        //            "altphonenumber = @altphonenumber" +
        //            "direccion = @direccion" +
        //            "ciudad = @ciudad" +
        //            "rol = @rol" +
        //            "departamento = @departamento" +
        //            "WHERE Id = @id", connection);
        //        command.Parameters.AddWithValue("@id", id);
        //        command.Parameters.AddWithValue("@fname", fname);
        //        command.Parameters.AddWithValue("@lname", lname);
        //        command.Parameters.AddWithValue("@sex", sex);
        //        command.Parameters.AddWithValue("@docid", docid);
        //        command.Parameters.AddWithValue("@DOB", dob);
        //        command.Parameters.AddWithValue("@email", email);
        //        command.Parameters.AddWithValue("@phonenumber", phonenumber);
        //        command.Parameters.AddWithValue("@altphonenumber", altphonenumber);
        //        command.Parameters.AddWithValue("@direccion", direccion);
        //        command.Parameters.AddWithValue("@ciudad", ciudad);
        //        command.Parameters.AddWithValue("@provincia", provincia);
        //        command.Parameters.AddWithValue("@rol", rol);
        //        command.Parameters.AddWithValue("@departamento", departamento);
        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            pass = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }

        //        return pass;
        //    }
    }
}
