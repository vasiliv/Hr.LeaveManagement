using Hr.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    //LeaveTypeDto - return type
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
