using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;
namespace SGA_api.Database
{
    public class SaveContained : ISaveContained
    {
        public void PostContained(Contained myContained)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"INSERT INTO d82kvyquj6n9y0g6.CONTAINED(OrderID, ProductID, NumOfItems) 
            VALUES(@OrderID, @ProductID, @NumOfItems)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@OrderID", myContained.OrderID);
            cmd.Parameters.AddWithValue("@ProductID", myContained.ProductID);
            cmd.Parameters.AddWithValue("@NumOfItems", myContained.NumOfItems);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}