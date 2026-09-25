using ProductApii.Models;

namespace ProductApii.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Product? GetById(int id);
    }
}