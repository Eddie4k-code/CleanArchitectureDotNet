using HRManagement.Domain;


namespace HRManagement.Application.Contracts.Persistence
{


    /* 
    
    
    Interface representing the repository for managing leave type.
    This interface should be implemented by infrastructure layers to provide data access for leave type operations.
    
    */

    public interface ILeaveTypeRepository : IGenericRepoistory<LeaveType> {

}

}