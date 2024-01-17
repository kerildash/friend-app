using Microsoft.AspNetCore.Mvc;

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
    public Friend Get(Guid id)
    {
		var friend = Friends.Find(x => x.Id == id);
		return friend is not null ? friend : throw new NullReferenceException();
    }
    public void Add(Friend friend)
	{
		Friends.Add(friend);
	}

	public void Edit(Friend friend)
	{
		var index = Friends.FindIndex(x => x.Id == friend.Id);
		if (index == -1)
		{
			throw new InvalidOperationException();
		}
		Friends[index] = friend;
	}
	public void Delete(Guid id)
	{		
		Friends.Remove(Get(id));
	}
}
