using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hol.visitor.Models;
using Microsoft.AspNetCore.Authorization;

namespace hol.visitor.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        DateTime d = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        _logger.LogInformation(d + " Call Index Page");
        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogInformation("Call Privacy Page");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

