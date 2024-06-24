using HRManagement.Domain;

namespace HRManagement.Application.Contracts.Persistence
{


    /* 

        Interface representing the repository for managing leave allocations.
        This interface should be implemented by infrastructure layers to provide data access for leave allocation operations.
        It extends the generic repository interface for the LeaveType entity.

    */


    public interface ILeaveAllocationRepository : IGenericRepoistory<LeaveAllocation> {

}

}