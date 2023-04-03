using SGA_api.Models;
namespace SGA_api.Interface
{
    public interface IReadData
    {
        public List<Product> GetAllProducts();
    }
}