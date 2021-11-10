using AppCatalogService.Core.Common.Entities;
using AppCatalogService.Core.Common.Interfaces;
using AppCatalogService.Core.Domain.Entities;
using Ardalis.Specification;

namespace AppCatalogService.Core.Application.Interfaces
{
    public interface IExampleRepository : IRepository<ExampleEntity>
    {
        //Example Additional Methods here
    }
}