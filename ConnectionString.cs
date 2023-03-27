namespace SGA_api
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString(){
            string server = "td5l74lo6615qq42.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "d82kvyquj6n9y0g6";
            string port = "3306";
            string username = "e4mm96t629a2zdjt";
            string password = "ufs6pbb8rch14vs3";

            cs = $@"server = {server};user={username};database={database}; port={port};password={password};";
        }
    }
}
    
