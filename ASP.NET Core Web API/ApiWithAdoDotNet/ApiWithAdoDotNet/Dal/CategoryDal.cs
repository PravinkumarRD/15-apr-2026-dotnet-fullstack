using ApiWithAdoDotNet.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ApiWithAdoDotNet.Dal;

public class CategoryDal
{
    private readonly IConfiguration _configuration;

    public CategoryDal(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public List<Category> GetAllCategories()
    {
        using (SqlConnection CN = new SqlConnection(_configuration.GetConnectionString("BajajEComConStr")))
        {
            using (SqlCommand CMD = new SqlCommand())
            {
                CN.Open();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "GetAllCategories";
                SqlDataReader DR = CMD.ExecuteReader();
                List<Category> categories = new List<Category>();
                while (DR.Read())
                {
                    Category category = new Category()
                    {
                        CategoryId = Convert.ToInt32(DR["CategoryId"]),
                        CategoryName = DR["CategoryName"].ToString(),
                        Description = DR["Description"].ToString()
                    };
                    categories.Add(category);
                }
                DR.Close();
                CN.Close();
                return categories;
            }

        }
    }
    public Category GetCategoryDetails(int categoryId)
    {
        using (SqlConnection CN = new SqlConnection(_configuration.GetConnectionString("BajajEComConStr")))
        {
            CN.Open();
            using (SqlCommand CMD = new SqlCommand())
            {
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "GetCategoryDetails";
                CMD.Parameters.AddWithValue("@p_CategoryId", categoryId);
                SqlDataReader DR = CMD.ExecuteReader();
                Category category = null;
                var result = DR.Read();
                if (!result)
                {
                    return category;
                }
                category = new Category()
                {
                    CategoryId = Convert.ToInt32(DR["CategoryId"]),
                    CategoryName = DR["CategoryName"].ToString(),
                    Description = DR["Description"].ToString()
                };

                DR.Close();
                CN.Close();
                return category;
            }

        }
    }
    public int AddCategory(Category category)
    {
        using (SqlConnection CN = new SqlConnection(_configuration.GetConnectionString("BajajEComConStr")))
        {
            using (SqlCommand CMD = new SqlCommand())
            {
                CN.Open();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "InsertCategory";
                CMD.Parameters.AddWithValue("@p_CategoryName", category.CategoryName);
                CMD.Parameters.AddWithValue("@p_Description", category.Description);
                int result = CMD.ExecuteNonQuery();
                CN.Close();
                return result;
            }
        }
    }
    public int UpdateCategory(Category category)
    {
        using (SqlConnection CN = new SqlConnection(_configuration.GetConnectionString("BajajEComConStr")))
        {

            using (SqlCommand CMD = new SqlCommand())
            {
                CN.Open();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "UpdateCategory";
                CMD.Parameters.AddWithValue("@p_CategoryId", category.CategoryId);
                CMD.Parameters.AddWithValue("@p_CategoryName", category.CategoryName);
                CMD.Parameters.AddWithValue("@p_Description", category.Description);
                int result = CMD.ExecuteNonQuery();
                CN.Close();
                return result;
            }
        }
    }
    public int DeleteCategory(int categoryId)
    {
        using (SqlConnection CN = new SqlConnection(_configuration.GetConnectionString("BajajEComConStr")))
        {

            using (SqlCommand CMD = new SqlCommand())
            {
                CN.Open();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "DeleteCategory";
                CMD.Parameters.AddWithValue("@p_CategoryId", categoryId);

                int result = CMD.ExecuteNonQuery();
                CN.Close();
                return result;
            }
        }
    }

}
