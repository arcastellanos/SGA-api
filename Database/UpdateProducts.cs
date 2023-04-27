using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;

namespace SGA_api.Database
{
    public class UpdateProducts : IUpdateProducts
    {
        public void UpdateProduct(int id, Product myProduct)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            string stm = @"UPDATE d82kvyquj6n9y0g6.PRODUCT set ProductID = @ProductID, ProductName = @ProductName,
            ProductCategory = @ProductCategory, ProductPrice= @ProductPrice, ProductUrl = @ProductUrl, Deleted = @Deleted
            ManagerID = @ManagerID where ProductID = @ProductID";

            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@ProductID", myProduct.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", myProduct.ProductName);
            cmd.Parameters.AddWithValue("@ProductCategory", myProduct.ProductCategory);
            cmd.Parameters.AddWithValue("@ProductPrice", myProduct.ProductPrice);
            cmd.Parameters.AddWithValue("@ProductUrl", myProduct.ProductUrl);
            cmd.Parameters.AddWithValue("@ManagerID", myProduct.ManagerID);
            cmd.Parameters.AddWithValue("@Deleted", false);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            System.Console.WriteLine(myProduct);
        }
    }
}