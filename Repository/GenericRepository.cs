
using AxisTrack.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AxisTrack.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {


        private readonly StoreContext _storeContext;

      

        public GenericRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
           
        }



        async Task<T> IGenericRepository<T>.AddAsync(T item)
        {
           await _storeContext.Set<T>().AddAsync(item);

            await _storeContext.SaveChangesAsync();
            return item;
        }

        async Task<bool> IGenericRepository<T>.DeleteAsync(int id)
        {
           var entity = await _storeContext.Set<T>().FindAsync(id);


            if (entity == null) return false;
                
            _storeContext.Set<T>().Remove(entity);

            return true;
            
        }

        async Task<IEnumerable<T>> IGenericRepository<T>.GetAllAsync()
        {
            return await _storeContext.Set<T>().AsNoTracking().ToListAsync();
        }

        async Task<T?> IGenericRepository<T>.GetByIdAsync(int id)
        {
           return await _storeContext.Set<T>().FindAsync(id);
        }

        async Task<T> IGenericRepository<T>.UpdateAsync(T item)
        {

            _storeContext?.Set<T>().Update(item);
            await _storeContext.SaveChangesAsync();
            return item;
        
        }
    }

}


