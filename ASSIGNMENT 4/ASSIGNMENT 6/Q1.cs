using System;
using System.Data.SqlClient;

class Class15
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        con.Open();

        string query = "SELECT * FROM Student";

        SqlCommand cmd = new SqlCommand(query, con);

        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine("Student ID: " + dr["StudentID"]);
            Console.WriteLine("Name: " + dr["Name"]);
            Console.WriteLine("Course: " + dr["Course"]);
            Console.WriteLine("Semester: " + dr["Semester"]);
            Console.WriteLine("----------------------");
        }

        dr.Close();
        con.Close();
    }
}