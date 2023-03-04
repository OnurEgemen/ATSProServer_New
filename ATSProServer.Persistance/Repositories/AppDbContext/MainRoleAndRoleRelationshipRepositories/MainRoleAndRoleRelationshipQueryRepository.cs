using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
{
    public MainRoleAndRoleRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
