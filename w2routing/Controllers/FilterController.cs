using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace w2routing.Controllers
{
    [Route("filter-tests")]
    public class FilterController : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }

        [HttpGet("")]
        public string Home()
        {
            return "Przykładowa odpowiedź";
        }
    }
}
