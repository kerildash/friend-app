namespace MVC.Models;

public class FriendRepository
{
	public List<Friend> Friends { get; set; }
	public FriendRepository()
	{
		Friends =
		[
			new Friend("Влад", "Тверь"),
			new Friend("Никита", "Бобруйск"),
			new Friend("Кеша", "Речица"),
			new Friend("Ярослав", "Волгоград"),
			new Friend("Артём", "Гомель"),
			new Friend("Андрэ Давтян", "Bo_Oston"),
		];
	}
	public List<Friend> GetAll()
	{
		return Friends;
	}
	public void Add(Friend friend)
	{
		Friends.Add(friend);
	}
}
