namespace SGA_api.Models
{
    public class Delivery
    {
        public int DeliveryID {get; set;}
        public string City {get; set;}
        public string ZipCode {get; set;}
        public string Street {get; set;}
        public string State {get; set;}
        public int OrderID {get; set;}
    }
}