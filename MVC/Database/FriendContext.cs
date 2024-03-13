using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Database;

public class FriendContext(DbContextOptions<FriendContext> options) : DbContext(options)
{
	public DbSet<Friend> Friends { get; set; }
}
