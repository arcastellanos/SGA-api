using SGA_api.Interface;
using MySql.Data.MySqlClient;
using SGA_api.Models;
namespace SGA_api.Database
{
    public class DeleteProducts : IDeleteProducts
    {
        void IDeleteProducts.DeleteProduct(int ProductID)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DELETE FROM d82kvyquj6n9y0g6.PRODUCT WHERE ProductID = @ProductID";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}