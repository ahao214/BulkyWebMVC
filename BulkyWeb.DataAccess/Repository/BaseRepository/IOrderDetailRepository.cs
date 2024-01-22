using BulkyWeb.Models;

namespace BulkyWeb.DataAccess.Repository.BaseRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);      
    }
}
