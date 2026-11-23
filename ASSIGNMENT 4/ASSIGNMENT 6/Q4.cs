using System;
using System.Data.SqlClient;

class Class18
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        con.Open();

        string query = "DELETE FROM Student WHERE StudentID=@id";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@id", 3);

        int result = cmd.ExecuteNonQuery();

        if (result > 0)
            Console.WriteLine("Student Deleted Successfully");
        else
            Console.WriteLine("Student Not Found");

        con.Close();
    }
}