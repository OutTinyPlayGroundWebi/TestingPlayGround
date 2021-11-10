using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace AppCatalogService.Api.ExceptionHandlingMiddleware
{
    public class ExceptionMiddleware : ExceptionFilterAttribute
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IWebHostEnvironment _environment;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IWebHostEnvironment environment)
        {
            _next = next;
            _logger = logger;
            _environment = environment;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        //ToDo: Exception Handling; Error Logging;
        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            switch (ex)
            {
                case ValidationException e:
                    context.Response.ContentType = "application/json"; ;
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    var response = new ErrorResponse
                    {
                        Error = new Error { Errors = new List<string>() }
                    };
                    response.Error.Code = (int)HttpStatusCode.BadRequest;
                    response.Error.Message = "validation failure";
                    foreach (var error in e.Errors)
                    {
                        response.Error.Errors.Add($"-- {error.PropertyName}: {error.ErrorMessage}");
                    }
                    return context.Response.WriteAsync(JsonSerializer.Serialize(response));
                case SqlException _:
                    context.Response.ContentType = "application/json"; ;
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    //ToDo: Log
                    _logger.LogError(ex, "Sql Error");
                    var errorMsg = _environment.IsDevelopment() ? ex.Message : "System Error"; //ToDo: Exception Handling
                    return context.Response.WriteAsync(JsonSerializer.Serialize(new ErrorResponse
                    {
                        Error = new Error
                        {
                            Code = (int)HttpStatusCode.InternalServerError,
                            Message = errorMsg
                        }
                    }));

                default:
                    context.Response.ContentType = "application/json"; ;
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    //ToDo: Log
                    _logger.LogError(ex, "Unhandled Error");
                    var errorText = _environment.IsDevelopment() ? ex.Message : "System Error"; //ToDo: Exception Handling
                    return context.Response.WriteAsync(JsonSerializer.Serialize(new ErrorResponse
                    {
                        Error = new Error
                        {
                            Code = (int)HttpStatusCode.InternalServerError,
                            Message = errorText
                        }
                    }));
            }




        }
    }
}
