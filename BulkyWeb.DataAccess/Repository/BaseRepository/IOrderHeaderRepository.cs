using BulkyWeb.Models;

namespace BulkyWeb.DataAccess.Repository.BaseRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
    }
}
