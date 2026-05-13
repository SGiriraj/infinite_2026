using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOFirstAssessment
{
    internal class SecondQuestion
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
            "server=ICS-LT-1G33YS3\\SQLEXPRESS;database=Employeemanagement;integrated security=true");

            // Stored Procedure
            SqlCommand cmd =
            new SqlCommand("sp_UpdateSalary", con);

            cmd.CommandType = CommandType.StoredProcedure;

            // Input Parameter
            cmd.Parameters.AddWithValue("@Empid", 3);

            con.Open();

            // Execute Procedure and Receive Salary
            object salary = cmd.ExecuteScalar();

            Console.WriteLine("Updated Salary : " + salary);

            con.Close();

            // Disconnected ADO.NET Starts
            

            SqlDataAdapter da =
            new SqlDataAdapter(
            "SELECT * FROM Employee_Details", con);

            DataSet ds = new DataSet();

            // Fill DataSet
            da.Fill(ds);

            Console.WriteLine("Employee Records");

            // Display Records
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(
                row["Empno"] + " " +
                row["EmpName"] + " " +
                row["Empsal"] + " " +
                row["Emptype"]);
            }

            Console.ReadLine();
        }
    }
}