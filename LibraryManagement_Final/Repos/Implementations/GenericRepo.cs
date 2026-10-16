using LibraryManagement_Final.Data;
using LibraryManagement_Final.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_Final.Repos.Implementations
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly AppDbContext context;
        public GenericRepo(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Create(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public async Task Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}