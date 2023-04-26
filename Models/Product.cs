namespace SGA_api.Models
{
    public class Product
    {
        public int ProductID {get; set;}
        public string ProductName {get; set;}
        public string ProductCategory {get; set;}
        public double ProductPrice {get; set;}
        public string ProductUrl {get; set;}
        public int ManagerID {get; set;}
        public bool Deleted {get; set;}
    }
}