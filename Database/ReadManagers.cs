using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA_api.Models;
using SGA_api.Database;
using SGA_api.Interface;
using MySql.Data.MySqlClient;

namespace SGA_api.Database
{
    public class ReadManagers : IReadManagers
    {
        public List<Manager> GetAllManagers()
        {
            List<Manager> allManagers = new List<Manager>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);

            con.Open();

            string stm = "SELECT * FROM d82kvyquj6n9y0g6.MANAGER";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) {
                Manager temp = new Manager(){ManagerID = rdr.GetInt32(0),  MUsername = rdr.GetString(1),  MPassword = rdr.GetString(2)};
                allManagers.Add(temp);
            }
            return allManagers;
        }
    }
}
