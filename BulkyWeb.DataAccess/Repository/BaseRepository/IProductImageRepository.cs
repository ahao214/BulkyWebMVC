using BulkyWeb.Models;


namespace BulkyWeb.DataAccess.Repository.BaseRepository
{
    public interface IProductImageRepository : IRepository<ProductImage>
    {
        void Update(ProductImage obj);
    }
}
