using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.UserAndFirmRelationshipRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.UserAndFirmRelationshipRepositories;

public class UserAndFirmRelationshipQueryRepository : AppQueryRepository<UserAndFirmRelationship>, IUserAndFirmRelationshipQueryRepository
{
    public UserAndFirmRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
