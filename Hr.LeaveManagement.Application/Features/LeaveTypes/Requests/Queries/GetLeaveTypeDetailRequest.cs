using Hr.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
