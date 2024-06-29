using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Application.Contracts.Persistence;

namespace HRManagement.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepoistory<T> where T : class
    {
        public GenericRepository() {
            
        }

        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}