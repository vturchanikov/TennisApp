﻿using Microsoft.EntityFrameworkCore;
using TennisApp.Models;

namespace TennisApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Game> Games { get; set; }
    public DbSet<Club> Clubs { get; set; }

    public DbSet<Address> Addresses { get; set; }
}
