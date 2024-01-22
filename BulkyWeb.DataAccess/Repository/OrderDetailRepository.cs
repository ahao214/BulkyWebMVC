using BulkyWeb.DataAccess.Data;
using BulkyWeb.DataAccess.Repository.BaseRepository;
using BulkyWeb.Models;

namespace BulkyWeb.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
