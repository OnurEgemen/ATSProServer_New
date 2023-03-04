using ATSProServer.Application.Messaging;
using System.Windows.Input;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;

public sealed record RemoveMainRoleCommand(
    string Id) : ICommand<RemoveMainRoleCommandResponse>;

