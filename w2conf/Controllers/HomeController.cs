using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using w2conf.Models;
using w2conf.Tools.Configuration;

namespace w2conf.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    private readonly ExampleSettings _exampleSettings;

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
        _exampleSettings = _configuration.GetSection("MyClass").Get<ExampleSettings>();
    }

    public IActionResult Index()
    {
        return View();
    }

    public ExampleSettings GetExampleSettings()
    {
        return _exampleSettings;
    }

    public String GetAdminData()
    {
        String name = _configuration["Administrator:Name"];
        String surname = _configuration["Administrator:Surname"];

        return name + " " + surname;
    }

    public String GetAdditionalData()
    {
        String name = _configuration["Additional:Name"];
        String surname = _configuration["Additional:Surname"];

        return name + " " + surname;
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
}
