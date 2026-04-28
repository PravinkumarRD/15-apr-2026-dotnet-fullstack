using Microsoft.Data.SqlClient;
using System.Data;

namespace DisconnectedArchitectureExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Microsoft SQL Server!");
        string connectionString = "Data Source=MSI;Database=BajajEcomDbApr26;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        string catQuery = "SELECT * FROM Categories";
        using (SqlConnection sqlconn = new SqlConnection(connectionString))
        {
            SqlDataAdapter DA = new SqlDataAdapter(catQuery, sqlconn);
            SqlCommandBuilder CB = new SqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS, "Categories");

            /*
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                Console.WriteLine($"Catgeory {row["CategoryName"]} and description - {row["Description"]}");
            }
            */
            //Insert New Row
            DataRow row = DS.Tables[0].NewRow();
            row["CategoryName"] = "Mobile Phones";
            row["Description"] = "All models of Samsung phones.";
            DS.Tables[0].Rows.Add(row);
            DA.Update(DS, "Categories");

            //Updating Row values
            DS.Tables[0].Rows[6]["Description"] = "Hello";
            //DA.Update(DS, "Categories");

            //Deleting Row
            DS.Tables[0].Rows[6].Delete();
            //DA.Update(DS, "Categories");
        }
    }
}
