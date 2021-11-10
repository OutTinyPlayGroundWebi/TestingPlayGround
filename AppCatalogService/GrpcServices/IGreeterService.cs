using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCatalogService.Api.GrpcServices
{
    public interface IGreeterService
    {
        Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context);
    }
}
