using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HRManagement.Application.Contracts.Persistence;

namespace HRManagement.Application.Commands.LeaveType
{
    public class CreateLeaveTypeHandler
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository) {

            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;

        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken) {

            //validate incoming data
            
            //convert dto to object
            var leaveTypeToCreate = this._mapper.Map<Domain.LeaveType>(request);

            //add to the database
            var record = this._leaveTypeRepository.CreateAsync(leaveTypeToCreate);



            //return record id
            return record.Id;



        }
    }
}