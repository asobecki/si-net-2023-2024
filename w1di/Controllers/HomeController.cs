using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using w1di.DI;
using w1di.Models;

namespace w1di.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IOperationScoped _operationScoped;
    private readonly IOperationSingleton _operationSingleton;
    private readonly IOperationTransient _operationTransient;

    public HomeController(ILogger<HomeController> logger, IOperationScoped _scoped, IOperationSingleton _singleton, IOperationTransient _transient)
    {
        _logger = logger;
        _operationScoped = _scoped;
        _operationSingleton = _singleton;
        _operationTransient = _transient;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Controller DI transient: " + _operationTransient.Id);
        _logger.LogInformation("Controller DI scoped: "+ _operationScoped.Id);
        _logger.LogInformation("Controller DI singleton: "+ _operationSingleton.Id);
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
}
