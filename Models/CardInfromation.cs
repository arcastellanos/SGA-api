namespace SGA_api.Models
{
    public class CardInformation
    {
        public int CardID {get; set;}
        public string CardNumber {get; set;}
        public string SecurityCode {get; set;}
        public DateTime ExpDate {get; set;}
        public string CHName {get; set;} 
    }
}