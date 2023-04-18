using SGA_api.Models;
using SGA_api.Interface;
using MySql.Data.MySqlClient;
namespace SGA_api.Database
{
    public class SaveCardInformation : ISaveCardInformation
    {
        public void PostCardInformation(CardInformation myCardInfo)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"INSERT INTO d82kvyquj6n9y0g6.CARD_INFORMATION(CardID, CardNumber, SecurityCode,
            ExpDate, CHName) 
            VALUES(@CardID, @CardNumber, @SecurityCode, @ExpDate, @CHName)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@CardID", myCardInfo.CardID);
            cmd.Parameters.AddWithValue("@CardNumber", myCardInfo.CardNumber);
            cmd.Parameters.AddWithValue("@SecurityCode", myCardInfo.SecurityCode);
            cmd.Parameters.AddWithValue("@ExpDate", myCardInfo.ExpDate);
            cmd.Parameters.AddWithValue("@CHName", myCardInfo.CHName);
            System.Console.WriteLine("are you getting here");

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}