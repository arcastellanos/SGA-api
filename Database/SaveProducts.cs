using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;
namespace SGA_api.Database
{
    public class SaveProducts : ISaveProducts
    {
        public void PostProduct(Product myProduct)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO d82kvyquj6n9y0g6.PRODUCT(ProductID, ProductName, ProductCategory,
            ProductPrice, ProductUrl, ManagerID) 
            VALUES(@ProductID, @ProductName, @ProductCategory, @ProductPrice, @ProductUrl, @ManagerID)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@ProductID", myProduct.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", myProduct.ProductName);
            cmd.Parameters.AddWithValue("@ProductCategory", myProduct.ProductCategory);
            cmd.Parameters.AddWithValue("@ProductPrice", myProduct.ProductPrice);
            cmd.Parameters.AddWithValue("@ProductUrl", myProduct.ProductUrl);
            cmd.Parameters.AddWithValue("@ManagerID", myProduct.ManagerID);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}