using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public string Hello() => "hello";
    }
}
