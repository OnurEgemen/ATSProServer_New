using ATSProServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using ATSProServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace ATSProServer.Presentation.Controller;

public class MainRoleAndRoleRelationshipsController : ApiController
{
    public MainRoleAndRoleRelationshipsController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
    {
        CreateMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);

    }


 




}
