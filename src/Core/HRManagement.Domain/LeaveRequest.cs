using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Domain.Common;

namespace HRManagement.Domain
{
    public class LeaveRequest : BaseEntity
    {

        public DateTime? StartDate {get; set;}

        public DateTime? EndDate {get; set;}

        public LeaveType? LeaveType {get; set;}

        public int LeaveTypeId {get; set;}

        public DateTime? DateRequested {get; set;}

        public string? RequestComments {get; set;}

        public bool? Approved {get; set;}

        public bool Cancelled {get; set;}

        public string RequestingEmployeeId {get; set;} = string.Empty;


    }
}