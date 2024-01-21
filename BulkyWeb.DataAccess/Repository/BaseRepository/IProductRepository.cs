using BulkyWeb.Models;


namespace BulkyWeb.DataAccess.Repository.BaseRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
