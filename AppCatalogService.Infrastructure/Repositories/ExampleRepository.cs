using AppCatalogService.Core.Application.Interfaces;
using AppCatalogService.Core.Domain.Entities;
using AppCatalogService.Infrastructure.Data;
using Ardalis.Specification.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogService.Infrastructure.Repositories
{
    public class ExampleRepository : EfBaseRepository<ExampleEntity>, IExampleRepository
    {
        public ExampleRepository(ExampleDbContext dbContext) : base(dbContext)
        {
        }
        //ToDo: 
    }
}
