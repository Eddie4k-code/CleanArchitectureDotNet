using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Domain;
using HRManagement.Domain.Common;
using HRManagement.Domain.Contracts.Persistance;

namespace HRManagement.Domain.Contracts.Persistance
{
    /* 
    
    A generic crud abstraction for implementing a repository 

    every new contract for a repository should implement this interface.
    
    */
    public interface IGenericRepoistory<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync();

        Task<T> DeleteAsync();

        Task<T> GetAsync();

        Task<T> GetByIdAsync();
    }
}









