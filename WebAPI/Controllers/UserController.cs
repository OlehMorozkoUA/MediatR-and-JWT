using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.classes;
using Repositories.interfaces;
using Services.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;
        public UserController(
            ILogger<UserController> logger,
            IUserRepository userRepository,
            IMediator mediator)
        {
            _logger = logger;
            _userRepository = userRepository;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task Seed()
        {
            await _userRepository.UserSeedAsync();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<UserModel>> LoginAsync(LoginQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<UserModel>> RegistrationAsync(ReqistrationCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
