using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testMvcApp.Models;

namespace testMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public List<string> summaries = new List<string> { "Hero" };

    public IActionResult Index()
    {
        Passing pass = new Passing
        {
            name = "Hafiz"
        };
        ViewBag.Data = pass;
        ViewBag.Summaries = summaries;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateSummaries([FromForm] Passing pass)
    {

        return Redirect("/");
    }

    [HttpPut]
    public IActionResult EditSummaries([FromForm] Passing pass)
    {
        return Redirect("/");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
