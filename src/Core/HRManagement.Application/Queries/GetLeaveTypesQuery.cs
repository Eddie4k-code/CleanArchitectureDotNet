using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace HRManagement.Application.Queries
{
    public record GetLeaveTypesQuery: IRequest<List<LeaveTypeDto>>;
}