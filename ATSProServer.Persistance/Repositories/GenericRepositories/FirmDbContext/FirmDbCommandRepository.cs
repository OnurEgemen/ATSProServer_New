using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories.GenericRepositories;
using ATSProServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance.Repository.GenericRepositories.FirmDbContext
{
    public class FirmDbCommandRepository<T> : ICommandGenericRepository<T>
        where T : Entity
    {
        

        private static readonly Func<Context.FirmDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((Context.FirmDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(x => x.Id == id));

        private Context.FirmDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (Context.FirmDbContext)context;
            Entity = _context.Set<T>();
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Entity.AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await Entity.AddRangeAsync(entities, cancellationToken);
        }


        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await GetByIdCompiled(_context, id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entity.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            Entity.UpdateRange(entities);
        }
    }
}
