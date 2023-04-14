using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;
namespace SGA_api.Database
{
    public class SaveOrders : ISaveOrders
    {
        public void PostOrder(Order myOrder)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"INSERT INTO d82kvyquj6n9y0g6.ORDERS(OrderID, OrderCost, CardID) 
            VALUES(@OrderID, @OrderCost, @CardID)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@OrderID", myOrder.OrderID);
            cmd.Parameters.AddWithValue("@OrderCost", myOrder.OrderCost);
            cmd.Parameters.AddWithValue("@CardID", myOrder.CardID);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}