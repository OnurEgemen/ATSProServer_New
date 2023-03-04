using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;
using ATSProServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ATSProServer.Presentation.Controller;

public sealed class MainRolesController : ApiController
{
    public MainRolesController(IMediator mediator) : base(mediator)
    {
    }


    [HttpPost("[action]")]
    public async Task<IActionResult>CreateMainRole(CreateMainRoleCommand request, CancellationToken
        cancellationToken)
    {
        CreateMainRoleResponse response = await _mediator.Send(request,cancellationToken);
        return Ok(response);

    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateStaticMainRoles(CancellationToken cancellationToken)
    {
        CreateStaticMainRolesCommand request = new(null);
        CreateStaticMainRolesResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);

    }
    
    [HttpPost("[action]")]
    public async Task<IActionResult> GetAllMainRole(GetAllMainRoleQuery request)
    {
        GetAllMainRoleQueryResponse response = await _mediator.Send(request);
        return Ok(response);

    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RemoveMainRoleById(RemoveMainRoleCommand request)
    {
        RemoveMainRoleCommandResponse response = await _mediator.Send(request);
        return Ok(response);

    }

    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateMainRole(UpdateMainRoleCommand request)
    {
        UpdateMainRoleCommandResponse response = await _mediator.Send(request);
        return Ok(response);

    }

}
