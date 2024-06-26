using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace HRManagement.Application.Commands.LeaveType
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {

        public string Name {get; set;} = string.Empty;

        public int DefaultDays {get; set;}
        
    }
}