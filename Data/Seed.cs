using TennisApp.Data.Enum;
using TennisApp.Models;

namespace TennisApp.Data;

public class Seed
{
    public static void SeedData(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(new List<Club>()
                {
                    new Club()
                    {
                        Title = "Running Club 1",
                        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Description = "This is the description of the first cinema",
                        ClubCategory = ClubCategory.Competitive,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                        }
                     },
                    new Club()
                    {
                        Title = "Running Club 2",
                        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Description = "This is the description of the first cinema",
                        ClubCategory = ClubCategory.Competitive,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                        }
                    },
                    new Club()
                    {
                        Title = "Running Club 3",
                        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Description = "This is the description of the first club",
                        ClubCategory = ClubCategory.Training,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                        }
                    },
                    new Club()
                    {
                        Title = "Running Club 3",
                        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Description = "This is the description of the first club",
                        ClubCategory = ClubCategory.Training,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Michigan",
                        }
                    }
                });
                context.SaveChanges();
            }

            //Games
            if (!context.Games.Any())
            {
                context.Games.AddRange(new List<Game>()
                {
                    new Game()
                    {
                        Title = "Running Race 1",
                        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Description = "This is the description of the first race",
                        GameCategory = GameCategory.Full,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                        }
                    },
                    new Game()
                    {
                        Title = "Running Race 2",
                        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        Description = "This is the description of the first race",
                        GameCategory = GameCategory.Short,
                        AddressId = 5,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                        }
                    }
                });
                context.SaveChanges();
            }
        }
    }
}