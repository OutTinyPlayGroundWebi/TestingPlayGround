using AppCatalogService.Core.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace AppCatalogService.Core.Application.Interfaces
{
    //ToDo: We may not need UnitOfWork
    public interface IUnitOfWork
    {
        IRepository<Domain.Entities.ApplicationEntity> ApplicationEntityRepositoryAlt { get; }
        IApplicationEntityRepository ApplicationEntityRepository { get; }
        Task<int> Complete(CancellationToken cancellationToken = default);
    }
}
