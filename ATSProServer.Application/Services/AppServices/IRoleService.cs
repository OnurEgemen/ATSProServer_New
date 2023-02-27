﻿using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using ATSProServer.Domain.AppEntities.Identity;

namespace ATSProServer.Application.Service.AppServices
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleCommand request);
        
        Task AddRangeAsync(IEnumerable<AppRole> roles);
        Task UpdateAsync(AppRole appRole);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>>GetAllRolesAsync();
        Task<AppRole> GetById(string id);

        Task<AppRole> GetByCode(string code);
    }
}
