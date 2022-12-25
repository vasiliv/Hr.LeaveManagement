﻿using AutoMapper;
using Hr.LeaveManagement.Application.DTOs.LeaveType;
using Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using Hr.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    // IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    // GetLeaveTypeListRequest - handler works on that particular request
    // LeaveTypeDto - return type
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            //added Id property to GetLeaveTypeDetailRequest class
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
