using AppCatalogService.Core.Common.Entities;
using AppCatalogService.Core.Common.Interfaces;
using AppCatalogService.Core.Domain.Entities;
using Ardalis.Specification;

namespace AppCatalogService.Core.Application.Interfaces
{
    public interface IApplicationEntityRepository : IRepository<ApplicationEntity>
    {
        //Example Additional Methods here
    }
}