using Microsoft.AspNetCore.Mvc;
using w2routing.Models;

namespace w2routing.Controllers
{
    [Route("value-provider")]
    public class BindingController : Controller
    {
        // FormValueProviderFactory
        // RouteValueProviderFactory
        // QueryStringValueProviderFactory
        // ...

        
        [Route("formvalue")]
        public IActionResult EntryPoint()
        {
            return View();
        }

        [HttpPost]
        [Route("form-value-provider")]
        public IActionResult TestFromValueBinding([FromForm] string email)
        {
            ViewData["type"] = "FromForm";
            ViewData["value"] = email;

            return View("Result");
        }
        
        // 1. Wejsciowy formularz
        //
        // 2. Obsługa fromForm
        //
        // 3. Obsługa fromRoute
        [HttpGet]
        [Route("route-value-provider/{id}")]
        public IActionResult TestRouteValueBinding([FromRoute] string id)
        {
            ViewData["type"] = "fromRoute";
            ViewData["value"] = id;
            return View("Result");
        }
        //
        // 4. Obsługa fromQuery
        [HttpGet]
        [Route("query-value-provider")]
        public string TestQueryValueBinding([FromQuery] string email)
        {
            return email;
        } 
        
        //
        // 5. Obsługa fromHeader
        [HttpGet]
        [Route("header-value-provider")]
        public string TestHeaderValueBinding([FromHeader(Name = "cokolwiek")] string email)
        {
            return email;
        }
        
        
        
        //
        // 6. Obsługa fromService
        [Route("di-provider")]
        [HttpGet]
        public IActionResult TestDependencyInjection([FromServices] IHttpContextAccessor accessor)
        {
            ViewData["type"] = "fromServices";
            ViewData["value"] = accessor.HttpContext.GetEndpoint().DisplayName;
            return View("Result");
        }
        //
        // 7. Obsługa fromBody

        [Route("body-value-provider")]
        [HttpPost]
        public IActionResult GetFromBody([FromBody] string email)
        {
            ViewData["type"] = "fromBody";
            ViewData["value"] = email;
            return View("Result");
            
        }
        [Route("body-value-provider-2")]
        [HttpPost]
        public DzikaKlasa GetFromBody2([FromBody] DzikaKlasa dzikaKlasa)
        {
            return dzikaKlasa;
        }
        
        [Route("body-value-provider-3")]
        [HttpPost]
        public DzikaKlasa GetFromBody3([Bind("Email")] DzikaKlasa dzikaKlasa)
        {
            return dzikaKlasa;
        }
        //
        // 8. Obsługa bindowania dla typów złożonych
        //
        // 9. Typy złożone z ograniczonymi polami do bindowania
        //
        // 10. Obsługa tokenu anulowania
        
    }
}
