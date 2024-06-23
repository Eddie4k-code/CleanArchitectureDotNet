using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Domain.Contracts.Persistance
{

    /* 
    
    Interface representing the repository for managing a leave request.
    This interface should be implemented by infrastructure layers to provide data access for leave request operations.    
    */



    public interface ILeaveRequestRepoistory : IGenericRepoistory<LeaveRequest> {

}
}