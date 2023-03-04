using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using ATSProServer.Application.Messaging;
using System.Windows.Input;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;

public sealed record CreateMainRoleCommand(
    string Title,
    string FirmId = null) : ICommand<CreateMainRoleResponse>;

