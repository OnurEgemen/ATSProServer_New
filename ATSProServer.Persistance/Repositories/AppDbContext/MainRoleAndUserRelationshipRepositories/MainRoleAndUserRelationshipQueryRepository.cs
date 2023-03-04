using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipQueryRepository
{
    public MainRoleAndUserRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
