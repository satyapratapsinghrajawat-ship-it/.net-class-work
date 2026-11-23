using System;
using System.Data;
using System.Data.SqlClient;

class Class19
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        string query = "SELECT * FROM Student";

        SqlDataAdapter da = new SqlDataAdapter(query, con);

        DataSet ds = new DataSet();

        da.Fill(ds, "Student");

        foreach (DataRow row in ds.Tables["Student"].Rows)
        {
            Console.WriteLine("Student ID: " + row["StudentID"]);
            Console.WriteLine("Name: " + row["Name"]);
            Console.WriteLine("Course: " + row["Course"]);
            Console.WriteLine("Semester: " + row["Semester"]);
            Console.WriteLine("----------------------");
        }
    }
}