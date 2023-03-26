using System.ComponentModel.DataAnnotations;

namespace TennisApp.Models;

public class AppUser
{
    [Key]
    public string Id { get; set; }

    public Address? Address { get; set; }
    public string Level { get; set; }

    public ICollection<Club> Clubs { get; set; }
    public ICollection<Game> Games { get; set; }
}
