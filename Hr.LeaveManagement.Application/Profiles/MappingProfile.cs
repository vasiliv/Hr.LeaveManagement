using AutoMapper;
using Hr.LeaveManagement.Application.DTOs;
using Hr.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //LeaveRequestListDto ar mimimatebia, 2-7
            CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
