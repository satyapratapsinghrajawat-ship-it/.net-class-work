using System;
using System.Data.SqlClient;

class Class16
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        con.Open();

        string query = "INSERT INTO Student VALUES (@id, @name, @course, @sem)";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@id", 4);
        cmd.Parameters.AddWithValue("@name", "Vikas");
        cmd.Parameters.AddWithValue("@course", "MCA");
        cmd.Parameters.AddWithValue("@sem", 2);

        int result = cmd.ExecuteNonQuery();

        if (result > 0)
            Console.WriteLine("Student Inserted Successfully");

        con.Close();
    }
}