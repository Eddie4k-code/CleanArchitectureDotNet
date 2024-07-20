using HRManagement.Application.Commands.LeaveType;
using HRManagement.Application.Queries;
using HRManagement.Application.Queries.LeaveType.GetLeaveTypeDetails;
using HRManagement.Application.Queries.LeaveType.LeaveTypeDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRManagement.API.Controllers {

[ApiController]
[Route("[controller]")]
public class LeaveTypeController : ControllerBase {

private readonly IMediator _mediator;    


public LeaveTypeController(IMediator mediator)
{

    this._mediator = mediator;

}


[HttpGet]
public async Task<List<LeaveTypeDto>> Get() {
    
    var leaveTypes = await _mediator.Send(new GetLeaveTypesQuery());

    return leaveTypes;


}

[HttpGet("{id}")]
public async Task<LeaveTypeDetailsDto> Get(int id) {
    var leaveType = await _mediator.Send(new GetLeaveTypeDetailsQuery(id));
    return leaveType;
}

[HttpPost]
public async Task<ActionResult> Post(CreateLeaveTypeCommand leaveType) {

    var createdLeaveType = await this._mediator.Send(leaveType);

    return CreatedAtAction(nameof(Get), new {id = createdLeaveType});
    

}





}



}