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
        private readonly AppCatalogDbContext _appCatalogDbContext;

        public IRepository<ApplicationEntity> ApplicationEntityRepositoryAlt { get; }

        public IApplicationEntityRepository ApplicationEntityRepository { get; }

        public UnitOfWork(
            AppCatalogDbContext appCatalogDbContext,
            IRepository<ApplicationEntity> applicationEntityAlt,
            IApplicationEntityRepository applicationEntityRepository
            )
        {
            _appCatalogDbContext = appCatalogDbContext;
            ApplicationEntityRepositoryAlt = applicationEntityAlt;
            ApplicationEntityRepository = applicationEntityRepository;
        }

        public async Task<int> Complete(CancellationToken cancellationToken = default)
        {
            //Because we only have 1 Db Context, otherwise transactionism
            return await _appCatalogDbContext.SaveChangesAsync(cancellationToken);
        }

    }
}
