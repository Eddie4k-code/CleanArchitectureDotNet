using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRManagement.Domain;
using HRManagement.Domain.Common;

namespace HRManagement.Persistence.DatabaseContext
{
    public class HRDatabaseContext : DbContext
    {


        public HRDatabaseContext(DbContextOptions<HRDatabaseContext> options) : base(options)
        {



            
        }


        public DbSet<LeaveType>  LeaveTypes {get; set;}

        public DbSet<LeaveAllocation> LeaveAllocations {get; set;}

        public DbSet<LeaveRequest> LeaveRequests {get; set;}




    }
}