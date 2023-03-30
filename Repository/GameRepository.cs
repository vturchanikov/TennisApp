using Microsoft.EntityFrameworkCore;
using TennisApp.Data;
using TennisApp.Interfaces;
using TennisApp.Models;

namespace TennisApp.Repository;

public class GameRepository : IGameRepository
{
    private readonly ApplicationDbContext _context;

    public GameRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public bool Add(Game game)
    {
        _context.Add(game);
        return Save();
    }

    public bool Delete(Game game)
    {
        _context.Remove(game);
        return Save();
    }

    public async Task<IEnumerable<Game>> GetAll()
    {
        return await _context.Games.ToListAsync();
    }

    public async Task<IEnumerable<Game>> GetAllGamesByCity(string city)
    {
        return await _context.Games.Where(c => c.Address.City.Contains(city)).ToListAsync();
    }

    public async Task<Game> GetByIdAsync(int id)
    {
        return await _context.Games.Include(g => g.Address).FirstOrDefaultAsync(g => g.Id == id);
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();

        return saved > 0 ? true : false;
    }

    public bool Update(Game game)
    {
        _context.Update(game);
        return Save();
    }
}
