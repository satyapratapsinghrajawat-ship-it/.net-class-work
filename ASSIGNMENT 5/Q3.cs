using System;
using System.Data.SqlClient;

class Class17
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        con.Open();

        string query = "UPDATE Student SET Name=@name, Course=@course, Semester=@sem WHERE StudentID=@id";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@id", 1);
        cmd.Parameters.AddWithValue("@name", "Rahul Singh");
        cmd.Parameters.AddWithValue("@course", "MCA");
        cmd.Parameters.AddWithValue("@sem", 3);

        int result = cmd.ExecuteNonQuery();

        if (result > 0)
            Console.WriteLine("Student Updated Successfully");
        else
            Console.WriteLine("Student Not Found");

        con.Close();
    }
}