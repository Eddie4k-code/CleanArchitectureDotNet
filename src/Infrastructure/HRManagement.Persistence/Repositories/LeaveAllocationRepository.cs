using HRManagement.Application.Contracts.Persistence;
using HRManagement.Domain;
using HRManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Persistence.Repositories {


    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(HRDatabaseContext context) : base(context)
        {


        }

        public async Task AddAllocation(List<LeaveAllocation> allocations)
        {
            await this._context.AddRangeAsync(allocations); //bulk add
            await this._context.SaveChangesAsync();
        }

        public async Task<bool> AllocationExists(string userId, int leaveTypeId, int period)
        {
            return await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == userId && q.LeaveTypeId == leaveTypeId && q.Period == period );
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(string userId)
        {

            var leaveAllocations = await this._context.LeaveAllocations.Where(q => q.EmployeeId == userId)
            .Include(q => q.LeaveType).ToListAsync();

            return leaveAllocations;
            
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
              var leaveAllocations = await this._context.LeaveAllocations.Include(q => q.LeaveType)
              .FirstOrDefaultAsync(q => q.Id == id);

            return leaveAllocations;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails()
        {
            var leaveAllocations = await this._context.LeaveAllocations.Include(q => q.LeaveType)
            .ToListAsync();

            return leaveAllocations;
        
        }

        public async Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId)
        {
            return await this._context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == userId && q.LeaveTypeId == leaveTypeId);
        }
    }


}