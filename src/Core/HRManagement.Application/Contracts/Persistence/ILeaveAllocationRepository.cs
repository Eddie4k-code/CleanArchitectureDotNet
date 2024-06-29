using HRManagement.Domain;

namespace HRManagement.Application.Contracts.Persistence
{


    /* 

        Interface representing the repository for managing leave allocations.
        This interface should be implemented by infrastructure layers to provide data access for leave allocation operations.
        It extends the generic repository interface for the LeaveType entity.

    */


    public interface ILeaveAllocationRepository : IGenericRepoistory<LeaveAllocation> {

        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);

        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();

        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(string userId);

        Task<bool> AllocationExists(string userId, int leaveTypeId, int period);

        Task AddAllocation(List<LeaveAllocation> allocations);

        Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId);

}

}