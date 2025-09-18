
using AxisTrack.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisTrack.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {


        private readonly StoreContext _storeContext;

        private readonly DbSet<T> _dbSet;

        public GenericRepository(StoreContext storeContext, DbSet<T> dbSet)
        {
            _storeContext = storeContext;
            _dbSet = dbSet;
        }



        Task<T> IGenericRepository<T>.AddAsync(T item)
        {
            throw new NotImplementedException();//a
        }

        Task<bool> IGenericRepository<T>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<T>> IGenericRepository<T>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<T?> IGenericRepository<T>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericRepository<T>.UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }

}


