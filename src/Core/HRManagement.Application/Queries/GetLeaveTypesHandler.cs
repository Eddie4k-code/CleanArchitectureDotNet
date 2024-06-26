using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HRManagement.Application.Contracts.Persistence;
using HRManagement.Domain;
using MediatR;

namespace HRManagement.Application.Queries
{
    public class GetLeaveTypesHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
    {

        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;


        public GetLeaveTypesHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {

            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
            
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {
            //query the database
            var leaveTypes = await this._leaveTypeRepository.GetAsync();

            //convert data objects to dto objects

            var leaveTypesMapped =  this._mapper.Map<List<LeaveTypeDto>>(leaveTypes);
           

            //return list of dto object

            return leaveTypesMapped;
        }
    }
}