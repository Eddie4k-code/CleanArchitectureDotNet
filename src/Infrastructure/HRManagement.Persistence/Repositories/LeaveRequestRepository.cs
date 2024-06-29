using HRManagement.Application.Contracts.Persistence;
using HRManagement.Domain;
using HRManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Persistence.Repositories {


    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepoistory 
    {
        public LeaveRequestRepository(HRDatabaseContext context) : base(context)
        {

        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequests = await this._context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();

            return leaveRequests;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId)
        {
           var leaveRequests = await this._context.LeaveRequests
           .Where(q => q .RequestingEmployeeId == userId)
           .Include(q => q.LeaveType)
           .ToListAsync();

           return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequests = await this._context.LeaveRequests.Include(q => q.LeaveType)
            .FirstOrDefaultAsync(q => q.Id == id);

            return leaveRequests;
        }
    }


}