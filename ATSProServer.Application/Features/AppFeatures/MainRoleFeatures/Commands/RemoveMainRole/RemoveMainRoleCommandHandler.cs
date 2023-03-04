using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;

public sealed class RemoveMainRoleCommandHandler : ICommandHandler<RemoveMainRoleCommand,
    RemoveMainRoleCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public RemoveMainRoleCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<RemoveMainRoleCommandResponse> Handle(RemoveMainRoleCommand request, CancellationToken cancellationToken)
    {
        await _mainRoleService.RemoveByIdAsync(request.Id);
        return new();
    }
}
