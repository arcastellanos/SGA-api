using SGA_api.Models;
using SGA_api.Database;
namespace SGA_api.Interface
{
    public interface IReadData
    {
        public List<Product> GetAllProducts();
    }
}