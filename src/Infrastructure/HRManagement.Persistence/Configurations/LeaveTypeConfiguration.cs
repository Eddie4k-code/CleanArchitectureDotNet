using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRManagement.Persistence.Configurations
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        
        public void Configure(EntityTypeBuilder<LeaveType> builder) {

            builder.HasData(
                new LeaveType
                {
                    Id = 1,
                    Name = "test",
                    DefaultDays = 1,
                }
            );

        }

    }


}