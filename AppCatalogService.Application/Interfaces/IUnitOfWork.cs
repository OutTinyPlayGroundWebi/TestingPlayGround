using AppCatalogService.Core.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace AppCatalogService.Core.Application.Interfaces
{
    //ToDo: We may not need UnitOfWork
    public interface IUnitOfWork
    {
        IRepository<ExampleEntity> ExampleRepositoryAlt { get; }
        IExampleRepository ExampleRepository { get; }
        Task<int> Complete(CancellationToken cancellationToken = default);
    }
}
