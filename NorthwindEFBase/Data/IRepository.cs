using System.Linq;
using System.Threading.Tasks;

namespace NorthwindEFBase.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> GetById(object id);
    }
}