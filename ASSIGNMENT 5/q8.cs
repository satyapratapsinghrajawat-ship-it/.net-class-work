using System;
using System.Data;
using System.Data.SqlClient;

class Class22
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);

        DataSet ds = new DataSet();

        da.Fill(ds, "Student");

        SqlCommand cmd = new SqlCommand(
            "DELETE FROM Student WHERE StudentID=@id", con);

        SqlParameter p = cmd.Parameters.Add("@id", SqlDbType.Int, 0, "StudentID");
        p.SourceVersion = DataRowVersion.Original;

        da.DeleteCommand = cmd;

        DataRow row = ds.Tables["Student"].Rows.Find(2);

        if (row == null)
        {
            Console.WriteLine("Student Not Found");
            return;
        }

        row.Delete();

        da.Update(ds, "Student");

        Console.WriteLine("Student Deleted Successfully");
    }
}