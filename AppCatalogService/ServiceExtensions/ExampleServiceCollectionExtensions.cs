using AppCatalogService.Core.Application.Common.Behaviours;
using AppCatalogService.Core.Application.Interfaces;
using AppCatalogService.Core.Domain.Entities;
using AppCatalogService.Infrastructure;
using AppCatalogService.Infrastructure.Data;
using AppCatalogService.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AppCatalogService.Api.ServiceExtensions
{

    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Example to add(register) all related feature services 
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="configurationSection"></param>
        public static void AddExampleServices(this IServiceCollection serviceCollection, IConfigurationSection configurationSection)
        {
            //serviceCollection.AddTransient<X, Y>();
            //serviceCollection.AddScoped<X, Y>();
            //serviceColletion.AddSingleton<X, Y>();
            //serviceCollection.Configure<ConfigModel>(configurationSection);
        }

        public static void AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
           
            serviceCollection.AddDbContext<ExampleDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DbConnectionString")));

            serviceCollection.AddScoped<ExampleDbContext>(provider => provider.GetService<ExampleDbContext>());

            #region Repositories
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(EfBaseRepository<>));
            serviceCollection.AddScoped(typeof(IExampleRepository), typeof(ExampleRepository));
            #endregion
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region MediatR & FluentValidator

            services.AddMediatR(Assembly.GetExecutingAssembly());

            // services.AddFluentValidation(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            #endregion

            return services;
        }

    }
}
