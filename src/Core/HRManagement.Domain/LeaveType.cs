using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Domain.Common;

namespace HRManagement.Domain
{
    public class LeaveType : BaseEntity
    {
        public string Name {get; set;} = string.Empty;

        public int DefaultDays {get; set;}
    }
}