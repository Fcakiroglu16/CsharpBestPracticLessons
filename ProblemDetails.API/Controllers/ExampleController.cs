using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemDetails.API.Models;

namespace ProblemDetails.API.Controllers
{

    public record ProductCreateRequestDto([Required] string Name, decimal Price);



    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            throw new DivideByZeroException();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(ProductCreateRequestDto request)
        {
           

            return Ok();
        }


        [HttpPut]
        public IActionResult Put(ProductCreateRequestDto request)
        {

            var validationError = CustomValidationProblemDetails.AddError(nameof(ProductCreateRequestDto.Name), "bu ürün veritabanında bulunmaktadır");




            return Ok(validationError);
        }
    }
}
