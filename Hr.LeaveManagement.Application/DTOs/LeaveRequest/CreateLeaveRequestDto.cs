using Hr.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto 
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //[ForeignKey("LeaveTypeId")]
        //public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        //public DateTime DateActioned { get; set; }
        //public bool? Approved { get; set; }
        //public bool Cancelled { get; set; }
    }
}
