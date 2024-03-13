using MVC.Models;

namespace MVC.Services
{
	public interface IFriendRepository
	{
		public void Add(Friend friend);
		public void Delete(Guid id);
		public void Edit(Friend friend);
		public Friend Get(Guid id);
		public List<Friend> GetAll();
	}
}