﻿using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;

public sealed record GetAllMainRoleQueryResponse(
    IList<MainRole> MainRoles);
