using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TennisApp.Data.Enum;

namespace TennisApp.Models;

public class Game
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? Image { get; set; }
    public int? EntryFee { get; set; }

    [ForeignKey("Address")]
    public int AddressId { get; set; }
    public Address Address { get; set; }

    public GameCategory GameCategory { get; set; }

    [ForeignKey("AppUser")]
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}
