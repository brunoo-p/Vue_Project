using System.Threading.Tasks;

namespace projeto_API.Data
{
    public interface IRepository
    {
         //Gerai
         void Add<T>(T entity) where T:class ;
         void Update<T>(T entity) where T:class;
         void Delete<T>(T entity) where T:class;
         Task<bool> SaveChangesAsync();
    }
}