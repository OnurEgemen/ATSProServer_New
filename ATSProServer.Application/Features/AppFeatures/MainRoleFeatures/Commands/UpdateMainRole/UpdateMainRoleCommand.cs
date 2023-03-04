using ATSProServer.Application.Messaging;
using System.Windows.Input;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;

public sealed record UpdateMainRoleCommand(
    string Id,
    string Title
    ) : ICommand<UpdateMainRoleCommandResponse>;
