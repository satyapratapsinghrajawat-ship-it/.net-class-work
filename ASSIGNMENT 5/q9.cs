using System;
using System.Data;
using System.Data.SqlClient;

class Class23
{
    static void Main()
    {
        string cs = @"Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);

        DataSet ds = new DataSet();

        da.Fill(ds, "Student");

        ds.Tables["Student"].PrimaryKey = new DataColumn[]
        {
            ds.Tables["Student"].Columns["StudentID"]
        };

        SqlCommandBuilder cb = new SqlCommandBuilder(da);

        DataRow row = ds.Tables["Student"].NewRow();

        row["StudentID"] = 10;
        row["Name"] = "Aman";
        row["Course"] = "MCA";
        row["Semester"] = 2;

        ds.Tables["Student"].Rows.Add(row);

        da.Update(ds, "Student");

        Console.WriteLine("Student Inserted Successfully");

        DataRow row2 = ds.Tables["Student"].Rows.Find(1);

        if (row2 != null)
        {
            row2["Name"] = "Rahul Kumar";
            da.Update(ds, "Student");
            Console.WriteLine("Student Updated Successfully");
        }

        DataRow row3 = ds.Tables["Student"].Rows.Find(10);

        if (row3 != null)
        {
            row3.Delete();
            da.Update(ds, "Student");
            Console.WriteLine("Student Deleted Successfully");
        }
    }
}