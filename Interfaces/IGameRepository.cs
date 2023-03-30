using TennisApp.Models;

namespace TennisApp.Interfaces;

public interface IGameRepository
{
    Task<IEnumerable<Game>> GetAll();

    Task<Game> GetByIdAsync(int id);
    Task<IEnumerable<Game>> GetAllGamesByCity(string city);

    bool Add(Game game);
    bool Update(Game game);
    bool Delete(Game game);
    bool Save();
}
