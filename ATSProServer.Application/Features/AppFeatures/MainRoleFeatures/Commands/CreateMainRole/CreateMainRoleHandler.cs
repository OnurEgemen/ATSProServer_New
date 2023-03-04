﻿using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public class CreateMainRoleHandler : ICommandHandler<CreateMainRoleCommand, CreateMainRoleResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateMainRoleHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateMainRoleResponse> Handle(CreateMainRoleCommand request, CancellationToken 
        cancellationToken)
    {
        MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndFirmId
            (request.Title,request.FirmId, cancellationToken);
        if (checkMainRoleTitle != null) throw new Exception("Bu rol daha Önce oluşturulmuştur!");

        MainRole mainRole = new(
            Guid.NewGuid().ToString(),
            request.Title,
            request.FirmId != null ? false : true,
            request.FirmId);

        await _mainRoleService.CreateAsync(mainRole, cancellationToken);

        return new();
    }
}
