using Hr.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}
