using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        //get endpoint
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Data = "Hello World :-)", IsSuccess = true });
            //return Ok("Hello World :-)");
        }
    }
}