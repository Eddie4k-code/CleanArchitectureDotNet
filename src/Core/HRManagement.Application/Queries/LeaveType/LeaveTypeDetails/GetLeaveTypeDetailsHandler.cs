using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HRManagement.Application.Contracts.Persistence;
using HRManagement.Application.Queries.LeaveType.GetLeaveTypeDetails;
using HRManagement.Application.Queries.LeaveType.LeaveTypeDetails;
using HRManagement.Domain;
using MediatR;

namespace HRManagement.Application.Queries
{
    public class GetLeaveTypeDetailsHandler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailsDto>
    {

        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;


        public GetLeaveTypeDetailsHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {

            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
            
        }

        public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            //query the database
            var leaveTypes = await this._leaveTypeRepository.GetByIdAsync(request.Id);

            //convert data objects to dto objects

            var leaveTypesMapped =  this._mapper.Map<LeaveTypeDetailsDto>(leaveTypes);
           

            //return list of dto object

            return leaveTypesMapped;
        }
    }
}