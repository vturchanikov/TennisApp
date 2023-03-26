using Microsoft.AspNetCore.Mvc;

namespace TennisApp.Controllers;

public class ClubController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
