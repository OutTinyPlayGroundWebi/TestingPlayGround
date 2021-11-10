using AppCatalogService.Api.ExceptionHandlingMiddleware;
using AppCatalogService.Api.WebControllers.Shared;
using AppCatalogService.Core.Application.Services.Example;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppCatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : BaseController
    {
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(ILogger<ApplicationController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> Post([FromBody] CreateCommand command)
        {
            var newEntityId = await Mediator.Send(command);
            return Ok(newEntityId);
        }

    }
}
