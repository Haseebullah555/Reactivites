using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : Controller
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??=
        HttpContext.RequestServices.GetService<IMediator>();
    }
}