using MediatR;
using ATSProServer.Presentation.Abstraction; 

namespace ATSProServer.Presentation.Controller;

public class UserAndFirmRelationshipsController : ApiController
{
    public UserAndFirmRelationshipsController(IMediator mediator) : base(mediator) {}
}
