using Hr.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        //we have it in BaseDomainEntity
        //public int Id { get; set; }
        public int NumberOfDays { get; set; }
        //we have it in BaseDomainEntity
        //public DateTime DateCreated { get; set; }
        //[ForeignKey("EmployeeId")]
        //public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        //[ForeignKey("LeaveTypeId")]
        //public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
