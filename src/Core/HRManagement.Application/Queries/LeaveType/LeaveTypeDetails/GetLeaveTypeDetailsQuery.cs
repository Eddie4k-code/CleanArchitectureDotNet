using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Application.Queries.LeaveType.GetLeaveTypeDetails;
using MediatR;

namespace HRManagement.Application.Queries.LeaveType.LeaveTypeDetails
{
    public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>
    {
        
    }
}