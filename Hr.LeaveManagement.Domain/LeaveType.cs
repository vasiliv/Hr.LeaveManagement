using Hr.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        //we have it in BaseDomainEntity
        //public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        //we have it in BaseDomainEntity
        //public DateTime DateCreated { get; set; }
    }
}
