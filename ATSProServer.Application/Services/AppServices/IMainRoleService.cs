using ATSProServer.Domain.AppEntities;
using Azure.Core;

namespace ATSProServer.Application.Service.AppServices;

public interface IMainRoleService
{
    Task<MainRole> GetByTitleAndFirmId(string title , string firmId,
        CancellationToken cancellationToken);
    Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);

    Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken);

    IQueryable<MainRole> GetAll();

    Task RemoveByIdAsync(string id);

    Task<MainRole> GetByIdAsync(string id);

    Task UpdateAsync(MainRole mainRole);
}
