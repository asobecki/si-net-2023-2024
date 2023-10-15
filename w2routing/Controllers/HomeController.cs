using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using w2routing.Models;

namespace w2routing.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet("/testConstraint/{param1:minlength(4)}")]
    public String TestIntConstraint(string param1)
    {
        return "Udało się. Przekazany parametr jest dłuższy niż 3 znaki.";
    }

    [HttpGet("/testCustomConstraint/{par1:int}/{par2:evenint}")]
    public String TestCustomConstraint(int par1, int par2)
    {

        return "Zadziałał customowy warunek dla argumentu routingu";
    }
}
