using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipCommandRepository
{
    public MainRoleAndUserRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
