using ATSProServer.Application.Messaging;
using System.Windows.Input;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;

public sealed record CreateMainRoleAndRoleRLCommand(
    string RoleId,
    string MainRoleId
    ):ICommand<CreateMainRoleAndRoleRLCommandResponse>;
