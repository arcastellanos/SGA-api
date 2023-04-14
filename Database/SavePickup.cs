using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;
namespace SGA_api.Database
{
    public class SavePickup : ISavePickup
    {
        public void PostPickup(Pickup myPickup)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"INSERT INTO d82kvyquj6n9y0g6.PICKUP(PickupID, City, ZipCode,
            Street, State, OrderID) 
            VALUES(@PickupID, @City, @ZipCode, @Street, @State, @OrderID)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@PickupID", myPickup.PickupID);
            cmd.Parameters.AddWithValue("@City", myPickup.City);
            cmd.Parameters.AddWithValue("@ZipCode", myPickup.ZipCode);
            cmd.Parameters.AddWithValue("@Street", myPickup.Street);
            cmd.Parameters.AddWithValue("@State", myPickup.State);
            cmd.Parameters.AddWithValue("@OrderID", myPickup.OrderID);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}