using HRManagement.Application.Queries;
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





}



}