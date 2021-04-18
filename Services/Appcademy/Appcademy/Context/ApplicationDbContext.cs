using System;
using Appcademy.Entities;
using Microsoft.EntityFrameworkCore;
namespace Appcademy.Context
{
  public class ApplicationDbContext: DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
  }
}
