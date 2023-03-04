using ATSProServer.Application.Service.AppServices;
using ATSProServer.Application.Service.FirmServices;
using ATSProServer.Persistance.Services.AppServices;
using ATSProServer.Persistance.Services.FirmServices;
using ATSProServer.Persistance;
using ATSProServer.Domain.Repositories.CompanyDbContext.CarRepositories;
using ATSProServer.Persistance.Repositories.FirmDbContext.CarRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Domain.UnitOfWorks;
using ATSProServer.Persistance.UnitOfWorks;
using ATSProServer.Domain;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.UserAndFirmRelationshipRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.UserAndFirmRelationshipRepositories;
using ATSProServer.Application.Services.AppServices;
//UsingSpot

namespace ATSProServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {

            #region Context - UnitOfWork
            services.AddScoped<IFirmDbUnitOfWork, FirmDbUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
                #region FirmDbContext


                services.AddScoped<ICarService, CarService>();
                
                //FirmServiceDISpot
            
                #endregion

                #region AppDbContext


                services.AddScoped<IFirmService, FirmService>();
                services.AddScoped<IRoleService, RoleService>();
                services.AddScoped<IMainRoleService, MainRoleService>();
                services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
                services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
                services.AddScoped<IUserAndFirmRelationshipService, UserAndFirmRelationshipService>();
                //AppServiceDISpot
                

                #endregion
            #endregion

            #region Repositories
                #region FirmDbContext

                services.AddScoped<ICarCommandRepository,CarCommandRepository>();
                services.AddScoped<ICarQueryRepository, CarQueryRepository>();
                
                //FirmRepositoryDISpot
                #endregion

            #region AppDbContext

                services.AddScoped<IFirmCommandRepository,FirmCommandRepository>();
                services.AddScoped<IFirmQueryRepository, FirmQueryRepository>();
                services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
                services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();

                //AppRepositorySpot
                #endregion
            #endregion
        }
    }
}


