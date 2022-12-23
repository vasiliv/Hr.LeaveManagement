﻿using Hr.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }   
        public LeaveTypeDto LeaveType { get; set; }                
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
