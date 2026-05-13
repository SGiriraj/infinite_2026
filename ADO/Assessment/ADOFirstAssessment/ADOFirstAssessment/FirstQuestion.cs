using System;
using System.Data;
using System.Data.SqlClient;


namespace ADOFirstAssessment
{
    
    class FirstQuestion
    {
        static void Main()
        {
            SqlConnection con = new SqlConnection(
            "server=ICS-LT-1G33YS3\\SQLEXPRESS;database=Employeemanagement;integrated security=true");

            SqlCommand cmd = new SqlCommand("sp_InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", "Vishal");
            cmd.Parameters.AddWithValue("@Empsal", 50000);
            cmd.Parameters.AddWithValue("@Emptype", "F");

            con.Open();

            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Inserted");

          
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
        }
    }
}
