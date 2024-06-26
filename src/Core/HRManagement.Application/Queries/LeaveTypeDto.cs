using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Application.Queries
{
    public class LeaveTypeDto
    {
        public string Name {get; set;} = string.Empty;

        public int DefaultDays {get; set;}
    }
}