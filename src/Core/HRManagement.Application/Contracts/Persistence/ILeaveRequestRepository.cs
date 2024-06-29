using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Domain;

namespace HRManagement.Application.Contracts.Persistence
{

    /* 
    
    Interface representing the repository for managing a leave request.
    This interface should be implemented by infrastructure layers to provide data access for leave request operations.    
    */



    public interface ILeaveRequestRepoistory : IGenericRepoistory<LeaveRequest> {

        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);

}
}