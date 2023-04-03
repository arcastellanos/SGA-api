// using System.Data;
// using MySql.Data;
using MySql.Data.MySqlClient;
using SGA_api.Models;
using SGA_api.Interface;

namespace SGA_api.Database
{
    public class ReadProducts : IReadData
    {
        public List<Product> ReadProducts()
        {
            List<Product> allProducts = new List<Product>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);

            con.Open();


        }
    }
}