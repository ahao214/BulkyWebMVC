

namespace BulkyWeb.DataAccess.Repository.BaseRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }
        void Save();
    }
}
