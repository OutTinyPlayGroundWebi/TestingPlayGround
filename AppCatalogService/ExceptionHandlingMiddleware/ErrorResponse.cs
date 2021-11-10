using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCatalogService.Api.ExceptionHandlingMiddleware
{
    //ToDo: Exception Handling;
    public class ErrorResponse
    {
        public Error Error { get; set; }
    }

    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
