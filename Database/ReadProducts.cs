// using System.Data;
// using MySql.Data;
using MySql.Data.MySqlClient;
using SGA_api.Models;
using SGA_api.Interface;

namespace SGA_api.Database
{
    public class ReadProducts : IReadData
    {
        public List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);

            con.Open();

            string stm = "SELECT * FROM d82kvyquj6n9y0g6.PRODUCT";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) {
                Product temp = new Product(){ProductID = rdr.GetInt32(0), ProductName = rdr.GetString(1), ProductCategory = rdr.GetInt32(2), ProductPrice = rdr.GetInt32(3), ManagerID = rdr.GetInt32(4)};
                allProducts.Add(temp);
            }
            return allProducts;
        }
    }
}