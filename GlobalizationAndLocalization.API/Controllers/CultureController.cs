using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace GlobalizationAndLocalization.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultureController(IStringLocalizer<CultureController> localizer, SharedLocalizationService sharedLocalizationService,IStringLocalizer<SharedResource> sharedResourceLocalizer) : ControllerBase
    {

        [HttpGet("Culture1")]
        public IActionResult Culture1()
        {
            return Ok(Thread.CurrentThread.CurrentCulture.Name);
        }



        [HttpGet("Culture2")]
        public IActionResult Culture2()
        {
            return Ok(new
            {
                Culture = CultureInfo.CurrentCulture.Name,
                CultureUI = CultureInfo.CurrentUICulture.Name
            });
        }


        [HttpGet("Culture3")]
        public IActionResult Culture3()
        {
            var currentCulture = CultureInfo.CurrentCulture;

            string currentDate = DateTime.Now.ToString("d", currentCulture); // Tam tarih formatı
            string currencyExample = string.Format(currentCulture, "{0:C}", 1234.56); // Para formatı

            return Ok(new
            {
                Culture = currentCulture.Name,
                Date = currentDate,
                Currency = currencyExample
            });
        }

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            //var message = string.Format(Messages.,
            //    "Ahmet");
            
            return Ok(string.Format(localizer["GreetingMessage"],"ahmet"));

        }

        [HttpGet("SharedLocalizerService")]
        public IActionResult SharedLocalizerService()
        {
            //var message = string.Format(Messages.,
            //    "Ahmet");

            return Ok(sharedLocalizationService.GetLocalizedString("Hello"));

        }


        [HttpGet("SharedResource")]
        public IActionResult SharedResource()
        {
            //var message = string.Format(Messages.,
            //    "Ahmet");

            return Ok(sharedResourceLocalizer["developer"]);

        }










        
    }
}
