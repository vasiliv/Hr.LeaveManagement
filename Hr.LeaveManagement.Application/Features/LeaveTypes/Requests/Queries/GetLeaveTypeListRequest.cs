using Hr.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    //GetLeaveTypeListRequestHandler - handler of this request
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
