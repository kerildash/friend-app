using MVC.Models;

namespace MVC.Database;

public class Seed (FriendContext context) { 

	public void SeedDataContext()
	{
		if (!context.Friends.Any())
		{
			List<Friend> friends = [
				new Friend("Влад", "Тверь"),
				new Friend("Никита", "Бобруйск"),
				new Friend("Кеша", "Речица"),
				new Friend("Ярослав", "Волгоград"),
				new Friend("Артём", "Гомель"),
				new Friend("Андрэ Давтян", "Bo_Oston"),
			];

			context.Friends.AddRange(friends);
			context.SaveChanges();
		};
	}
}
