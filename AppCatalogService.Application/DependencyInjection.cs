using AppCatalogService.Core.Application.Common.Behaviours;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogService.Core.Application
{
    public static class DependencyInjection
    {
        //ToDo: moved to Presentation Layer
        //public static IServiceCollection AddApplication(this IServiceCollection services)
        //{

        //    services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //    #region MediatR & FluentValidator

        //    services.AddMediatR(Assembly.GetExecutingAssembly());

        //    // services.AddFluentValidation(new[] { Assembly.GetExecutingAssembly() });
        //    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

        //    #endregion

        //    return services;
        //}
    }

}
