using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;
namespace SGA_api.Database
{
    public class SaveDelivery : ISaveDelivery
    {
        public void PostDelivery(Delivery myDelivery)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"INSERT INTO d82kvyquj6n9y0g6.DELIVERY(DeliveryID, City, ZipCode,
            Street, State, OrderID) 
            VALUES(@DeliveryID, @City, @ZipCode, @Street, @State, @OrderID)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@DeliveryID", myDelivery.DeliveryID);
            cmd.Parameters.AddWithValue("@City", myDelivery.City);
            cmd.Parameters.AddWithValue("@ZipCode", myDelivery.ZipCode);
            cmd.Parameters.AddWithValue("@Street", myDelivery.Street);
            cmd.Parameters.AddWithValue("@State", myDelivery.State);
            cmd.Parameters.AddWithValue("@OrderID", myDelivery.OrderID);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}