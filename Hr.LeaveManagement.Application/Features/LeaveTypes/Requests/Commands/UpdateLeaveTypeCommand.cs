using Hr.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    //Unit - returns nothing
    public class UpdateLeaveTypeCommand : IRequest<Unit>    
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
