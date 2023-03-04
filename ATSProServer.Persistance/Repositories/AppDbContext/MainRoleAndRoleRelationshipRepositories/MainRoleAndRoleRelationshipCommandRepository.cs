using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

public class MainRoleAndRoleRelationshipCommandRepository : AppCommandRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipCommandRepository
{
    public MainRoleAndRoleRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
