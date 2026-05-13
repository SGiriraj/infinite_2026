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

            SqlCommand cmd =
            new SqlCommand("sp_UpdateSalary", con);

            cmd.CommandType = CommandType.StoredProcedure;

            // Input Parameter
            cmd.Parameters.AddWithValue("@Empid", 3);

            con.Open();

            // Receive Updated Salary
            object salary = cmd.ExecuteScalar();

            Console.WriteLine("Updated Salary : " + salary);
            SqlCommand cmd2 = new SqlCommand(
           "SELECT * FROM Employee_Details", con);

            SqlDataReader dr = cmd2.ExecuteReader();

            Console.WriteLine("Employee Records");

            while (dr.Read())
            {
                Console.WriteLine(
                dr["Empno"] + " " + dr["EmpName"] + " " +
                dr["Empsal"] + " " +
                dr["Emptype"]);
            }


            con.Close();

            Console.ReadLine();
        }
    }
}