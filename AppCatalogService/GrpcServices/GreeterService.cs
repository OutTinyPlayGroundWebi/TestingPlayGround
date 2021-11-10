using Grpc.Core;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AppCatalogService.Api.GrpcServices
{
    //ToDo: Move To Application Layer
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        protected readonly IMediator _mediator;

        public GreeterService(IMediator mediator, ILogger<GreeterService> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {

            return Task.FromResult(new HelloReply
            {
                Message = "Hel: " + request.Name
            });
        }
    }
}
