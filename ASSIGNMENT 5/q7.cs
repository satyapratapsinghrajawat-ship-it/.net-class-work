using System;
using System.Data;
using System.Data.SqlClient;

class Class21
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);

        DataSet ds = new DataSet();

        da.Fill(ds, "Student");

        SqlCommand cmd = new SqlCommand(
            "UPDATE Student SET Name=@name, Course=@course, Semester=@sem WHERE StudentID=@id", con);

        cmd.Parameters.Add("@name", SqlDbType.VarChar, 50, "Name");
        cmd.Parameters.Add("@course", SqlDbType.VarChar, 50, "Course");
        cmd.Parameters.Add("@sem", SqlDbType.Int, 0, "Semester");

        SqlParameter p = cmd.Parameters.Add("@id", SqlDbType.Int, 0, "StudentID");
        p.SourceVersion = DataRowVersion.Original;

        da.UpdateCommand = cmd;

        DataRow row = ds.Tables["Student"].Rows.Find(1);

        if (row == null)
        {
            Console.WriteLine("Student Not Found");
            return;
        }

        row["Name"] = "Aman";
        row["Course"] = "MCA";
        row["Semester"] = 4;

        da.Update(ds, "Student");

        Console.WriteLine("Student Updated Successfully");
    }
}