using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisApp.Data;
using TennisApp.Models;

namespace TennisApp.Controllers;

public class ClubController : Controller
{
    private readonly ApplicationDbContext _context;

    public ClubController(ApplicationDbContext context)
    {
        _context = context;
    }

    public ApplicationDbContext Context { get; }

    public IActionResult Index()
    {
        var clubs = _context.Clubs.ToList();

        return View(clubs);
    }

    public IActionResult Detail(int id)
    {
        Club club = _context.Clubs.Include(c => c.Address).FirstOrDefault(c => c.Id == id);

        return View(club);
    }
}
