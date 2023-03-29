using Microsoft.AspNetCore.Mvc;
using TennisApp.Data;

namespace TennisApp.Controllers;

public class GameController : Controller
{
    private readonly ApplicationDbContext _context;

    public GameController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var games = _context.Games.ToList();

        return View(games);
    }
}
