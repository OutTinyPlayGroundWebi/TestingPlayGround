using AppCatalogService.Core.Application.Interfaces;
using AppCatalogService.Core.Common.Entities;
using AppCatalogService.Core.Common.Interfaces;
using AppCatalogService.Infrastructure.Data;
using Ardalis.Specification.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogService.Infrastructure.Repositories
{
    public class EfBaseRepository<T> : RepositoryBase<T>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        public EfBaseRepository(ExampleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
