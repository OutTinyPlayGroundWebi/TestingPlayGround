using AppCatalogService.Core.Application.Interfaces;
using AppCatalogService.Core.Domain.Entities;
using AppCatalogService.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppCatalogService.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExampleDbContext _exampleDbContext;

        public IRepository<ExampleEntity> ExampleRepositoryAlt { get; }

        public IExampleRepository ExampleRepository { get; }

        public UnitOfWork(
            ExampleDbContext exampleDbContext,
            IRepository<ExampleEntity> exampleRepositoryAlt,
            IExampleRepository exampleRepository
            )
        {
            _exampleDbContext = exampleDbContext;
            ExampleRepositoryAlt = exampleRepositoryAlt;
            ExampleRepository = exampleRepository;
        }

        public async Task<int> Complete(CancellationToken cancellationToken = default)
        {
            //Because we only have 1 Db Context, otherwise transactionism
            return await _exampleDbContext.SaveChangesAsync(cancellationToken);
        }

    }
}
