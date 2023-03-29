using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisApp.Data;
using TennisApp.Models;

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

    public IActionResult Detail(int id)
    {
        Game game = _context.Games.Include(c => c.Address).FirstOrDefault(c => c.Id == id);

        return View(game);
    }
}
