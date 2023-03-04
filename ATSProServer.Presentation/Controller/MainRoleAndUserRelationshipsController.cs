using MediatR;
using ATSProServer.Presentation.Abstraction; 

namespace ATSProServer.Presentation.Controller;

public class MainRoleAndUserRelationshipsController : ApiController
{
    public MainRoleAndUserRelationshipsController(IMediator mediator) : base(mediator) {}
}
