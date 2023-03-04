using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.UserAndFirmRelationshipRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.UserAndFirmRelationshipRepositories;

public class UserAndFirmRelationshipCommandRepository : AppCommandRepository<UserAndFirmRelationship>, IUserAndFirmRelationshipCommandRepository
{
    public UserAndFirmRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
