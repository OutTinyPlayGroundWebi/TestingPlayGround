using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCatalogService.Api.GrpcServices
{
    public abstract class BaseGrpcController
    {
        protected readonly IMediator _mediator;

        public BaseGrpcController(IMediator mediator)
        {
            _mediator = mediator;
        }

    }
}
