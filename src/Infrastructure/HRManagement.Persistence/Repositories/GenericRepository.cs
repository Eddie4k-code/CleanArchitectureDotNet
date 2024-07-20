using HRManagement.Application.Contracts.Persistence;
using HRManagement.Domain.Common;
using HRManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Persistence.Repositories {


    public class GenericRepository<T> : IGenericRepoistory<T> where T : BaseEntity
    {

        protected readonly HRDatabaseContext _context;


        public GenericRepository(HRDatabaseContext context) {

            this._context = context;

        }

        public async Task CreateAsync(T entity)
        {
            await this._context.AddAsync(entity);
            await this._context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            this._context.Remove(entity);
            
           await this._context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await this._context.Set<T>().FirstOrDefaultAsync(q => q.Id == Id);
        }

        public async Task UpdateAsync(T entity)
        {
            this._context.Update(entity);

            await this._context.SaveChangesAsync();
        }
    }


}
