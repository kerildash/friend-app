using Microsoft.AspNetCore.Mvc;
using MVC.Models;


namespace MVC.Controllers;

public class FriendController : Controller
{
	public FriendRepository Repository;
	public FriendController()
	{
		Repository = new FriendRepository();
	}
	[HttpGet]
	public IActionResult Index()
	{
		List<MVC.Models.Friend> friends = Repository.GetAll();
		return View(model: friends, viewName: "Index");
	}
	[HttpGet]
	public IActionResult Add()
	{
		return View(viewName: "Add");
	}

}
