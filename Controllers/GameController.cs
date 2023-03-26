using Microsoft.AspNetCore.Mvc;

namespace TennisApp.Controllers;

public class GameController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
