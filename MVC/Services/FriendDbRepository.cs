using MVC.Database;
using MVC.Models;

namespace MVC.Services
{
	public class FriendDbRepository(FriendContext context) : IFriendRepository
	{
		public void Add(Friend friend)
		{
			context.Add(friend);
			context.SaveChanges();
		}
		public void Delete(Guid id)
		{
			if (!Exists(id)){
				throw new ArgumentException($"Friend with id {id} does not exist.");
			};
			var friend = Get(id);
			context.Friends.Remove(friend);
			context.SaveChanges();
		}
		public void Edit(Friend friend)
		{
			if (!Exists(friend.Id))
			{
				throw new ArgumentException($"Friend with id {friend.Id} does not exist.");
			};			
			context.Friends.Update(friend);
			context.SaveChanges();
		}
		public Friend Get(Guid id)
		{
			if (!Exists(id))
			{
				throw new ArgumentException($"Friend with id {id} does not exist.");
			};
			return context.Friends.Where(x => x.Id == id).First();			
		}
		public List<Friend> GetAll()
		{
			return context.Friends.ToList();
		}
		private bool Exists(Guid id)
		{
			return context.Friends.Any(f => f.Id == id);
		}
	}
}
