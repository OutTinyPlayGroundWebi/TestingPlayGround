using AppCatalogService.Core.Common.Entities;
using AppCatalogService.Core.Common.Interfaces;
using Ardalis.Specification;

namespace AppCatalogService.Core.Application.Interfaces
{
    public interface IRepository<T> : IRepositoryBase<T> where T : BaseEntity, IAggregateRoot
    {

    }
}