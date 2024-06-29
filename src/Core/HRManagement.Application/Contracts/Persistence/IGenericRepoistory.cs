using HRManagement.Domain.Common;

namespace HRManagement.Application.Contracts.Persistence
{
    /* 
    
    A generic crud abstraction for implementing a repository 

    every new contract for a repository should implement this interface.
    
    */
    public interface IGenericRepoistory<T> where T : class
    {
        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync();

        Task<T> DeleteAsync();

        Task<List<T>> GetAsync();

        Task<T> GetByIdAsync(int Id);
    }
}









