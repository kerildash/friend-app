using Microsoft.EntityFrameworkCore;
using MVC.Database;
using MVC.Services;

namespace MVC;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddScoped<IFriendRepository, FriendDbRepository>();
		builder.Services.AddTransient<Seed>();
		// Add services to the container.
		builder.Services.AddControllersWithViews();
		builder.Services.AddDbContext<FriendContext>(
			options => options.UseSqlServer(
				builder.Configuration.GetConnectionString("DefaultConnection")));

		var app = builder.Build();

		#region seeding the data
		if (args.Length == 1 && args[0].ToLower() == "seeddata")
			SeedData(app);
		#endregion

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Friend}/{action=Index}/{id?}");

		app.Run();
	}
	private static void SeedData(IHost app)
	{
		var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

		using (var scope = scopedFactory.CreateScope())
		{
			var service = scope.ServiceProvider.GetService<Seed>();
			service.SeedDataContext();
		}
	}
}
