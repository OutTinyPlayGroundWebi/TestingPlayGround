using AppCatalogService.Core.Domain.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogService.Core.Application.Common.Specifications
{
    public class ExampleEntitySpecification : Specification<ExampleEntity>
    {
        public ExampleEntitySpecification(int skip, int take, string elasticSearchKeyWord, string filterFirstName, string filterLastName, string filterIdentCode, DateTime? filterBirthDate, string cityFilter, string genderFilter, string phoneFilter)
           : base()
        {
            //ToDo:
            //Example Code Below
            //Query.Include(i => i.GenderNavigation).Include(i => i.City).Include(i => i.PhoneBook).ThenInclude(i => i.PhoneNumberTypeNavigation);

            //Query
            //    .FirstNameFilter(filterFirstName)
            //    .LastNameFilter(filterLastName)
            //    .IdentCodeFilter(filterIdentCode)
            //    .BirthDateFilter(filterBirthDate)                
            //    .GenderFilter(genderFilter)               
            //    .CityFilter(cityFilter)
            //    .ElasticFilter(elasticSearchKeyWord)                
            //    .Skip(skip).Take(take);
        }
    }


    #region ExampleEntitySpecificationExtensions
    public static class ExampleEntitySpecificationExtensions
    {
        public static ISpecificationBuilder<ExampleEntity> FirstNameFilter(
            this ISpecificationBuilder<ExampleEntity> specificationBuilder, string searchKeyWord)
        {
            //ToDo:
            //Example Code Below
            //if (!string.IsNullOrWhiteSpace(searchKeyWord))
            //{
            //    ((List<Expression<Func<ExampleEntity, bool>>>)specificationBuilder.Specification.WhereExpressions).Add(i => i.FirstName.ToUpper().Contains(searchKeyWord.ToUpper()));
            //}
            //return specificationBuilder;
            throw new NotImplementedException("ExampleEntitySpecificationExtensions Not Implemented.");
        }

    }
    #endregion
}
