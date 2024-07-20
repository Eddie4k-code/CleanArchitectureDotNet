using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HRManagement.Application.Commands.LeaveType;
using HRManagement.Application.Queries;
using HRManagement.Application.Queries.LeaveType.GetLeaveTypeDetails;
using HRManagement.Domain;

namespace HRManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {


        public LeaveTypeProfile()
        {

            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>();
            CreateMap<CreateLeaveTypeCommand, LeaveType>();
            
        }
        
    }
}