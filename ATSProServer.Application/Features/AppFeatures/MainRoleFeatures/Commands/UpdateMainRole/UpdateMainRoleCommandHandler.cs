using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;

public sealed class UpdateMainRoleCommandHandler : ICommandHandler<UpdateMainRoleCommand, UpdateMainRoleCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public UpdateMainRoleCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<UpdateMainRoleCommandResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
    {
        MainRole mainRole = await _mainRoleService.GetByIdAsync(request.Id);

        if (mainRole == null) throw new Exception("Böyle bir ana rol bulunamadı!");
        
        if (mainRole.Title == request.Title) throw new Exception("Güncellediğiniz ana rol adı farklı olmalı!");
        
        if (mainRole.Title != request.Title)
        {
            MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndFirmId(request.Title, mainRole.FirmId, cancellationToken);
            if (checkMainRoleTitle != null) throw new Exception("Bu rol adı daha önce kullanılmış!");
        }

        mainRole.Title = request.Title;
        await _mainRoleService.UpdateAsync(mainRole);
        return new();
    }
}
