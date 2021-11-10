using System;
using System.Collections.Generic;
using System.Linq;
using AppCatalogService.Core.Application.Common.Mappings;
using AppCatalogService.Core.Domain.Entities;
using AutoMapper;

namespace AppCatalogService.Core.Application.Services.Example
{
    public class ApplicationEntityViewModel : IMapFrom<ApplicationEntity>
    {
        //ToDo: Properties here

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ApplicationEntity, ApplicationEntityViewModel>();
        }
    }
}
