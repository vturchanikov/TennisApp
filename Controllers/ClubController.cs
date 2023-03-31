using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisApp.Data;
using TennisApp.Interfaces;
using TennisApp.Models;

namespace TennisApp.Controllers;

public class ClubController : Controller
{
    private readonly IClubRepository _clubRepository;

    public ClubController(IClubRepository clubRepository)
    {
        _clubRepository = clubRepository;
    }

    public ApplicationDbContext Context { get; }

    public async Task<IActionResult> Index()
    {
        var clubs = await _clubRepository.GetAll();

        return View(clubs);
    }

    public async Task<IActionResult> Detail(int id)
    {
        Club club = await _clubRepository.GetByIdAsync(id);

        return View(club);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Club club)
    {
        if (ModelState.IsValid == false)
        {
            return View(club);
        }

        _clubRepository.Add(club);
        return RedirectToAction("Index");
    }
}
