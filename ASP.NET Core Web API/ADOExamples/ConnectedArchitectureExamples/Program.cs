using Microsoft.Data.SqlClient;
using System.Data;

namespace ConnectedArchitectureExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Connected Architecture Examples!");
        string connectionString = "Data Source=MSI;Database=BajajEcomDbApr26;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //string catQuery = "SELECT * FROM Categories";
        //using (SqlConnection sqlconn = new SqlConnection(connectionString))
        //{
        //    sqlconn.Open();
        //    SqlCommand CMD = new SqlCommand(catQuery, sqlconn);
        //    SqlDataReader DR = CMD.ExecuteReader();

        //    while (DR.Read())
        //    {
        //        Console.WriteLine($"Category {DR["CategoryName"]} and description - {DR["Description"]} !");
        //    }
        //    DR.Close();
        //    sqlconn.Close();
        //}
        // Using Stored Procedure To fetch categories
        //using (SqlConnection sqlconn = new SqlConnection(connectionString))
        //{
        //    sqlconn.Open();
        //    SqlCommand CMD = new SqlCommand();
        //    CMD.CommandType = CommandType.StoredProcedure;
        //    CMD.Connection = sqlconn;
        //    CMD.CommandText = "GetAllCategories";
        //    SqlDataReader DR = CMD.ExecuteReader();

        //    while (DR.Read())
        //    {
        //        Console.WriteLine($"Category {DR["CategoryName"]} and description - {DR["Description"]} !");
        //    }
        //    DR.Close();
        //    sqlconn.Close();
        //}


        // Using Stored Procedure To insert a new category
        /*using (SqlConnection sqlconn = new SqlConnection(connectionString))
        {
            sqlconn.Open();
            SqlCommand CMD = new SqlCommand();
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.Connection = sqlconn;
            CMD.CommandText = "InsertCategory";
            CMD.Parameters.AddWithValue("@p_CategoryName","Tablets");
            CMD.Parameters.AddWithValue("@p_Description", "All Company Tablets!");
            int result = CMD.ExecuteNonQuery();
            if (result>0)
            {
                Console.WriteLine("Category inserted successfully!");
            }
            else
            {
                Console.WriteLine("Category insertion failed!");
            }
            sqlconn.Close();
        }
      
        using (SqlConnection sqlconn = new SqlConnection(connectionString))
        {
            sqlconn.Open();
            SqlCommand CMD = new SqlCommand();
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.Connection = sqlconn;
            CMD.CommandText = "UpdateCategory";
            CMD.Parameters.AddWithValue("@p_CategoryId", 10);
            CMD.Parameters.AddWithValue("@p_CategoryName", "Google Tablets");
            CMD.Parameters.AddWithValue("@p_Description", "All Tablets From Google!");
            int result = CMD.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Category updated successfully!");
            }
            else
            {
                Console.WriteLine("Category update failed!");
            }
            sqlconn.Close();
        }  
        */
        using (SqlConnection sqlconn = new SqlConnection(connectionString))
        {
            sqlconn.Open();
            SqlCommand CMD = new SqlCommand();
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.Connection = sqlconn;
            CMD.CommandText = "DeleteCategory";
            CMD.Parameters.AddWithValue("@p_CategoryId", 10);
           
            int result = CMD.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Category deleted successfully!");
            }
            else
            {
                Console.WriteLine("Category deletion failed!");
            }
            sqlconn.Close();
        }
    }
}
