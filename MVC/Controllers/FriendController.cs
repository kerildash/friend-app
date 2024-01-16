using Microsoft.AspNetCore.Mvc;
using MVC.Models;


namespace MVC.Controllers;

public class FriendController : Controller
{
	public FriendRepository Repository;
	public FriendController(FriendRepository repository)
	{
		Repository = repository;
	}
	[HttpGet]
	public IActionResult Index()
	{
		List<Friend> friends = Repository.GetAll();
		return View(model: friends, viewName: "Index");
	}
	[HttpGet]
	public IActionResult Add()
	{
		return View(viewName: "Add");
	}
	[HttpPost]
	public IActionResult Add(string name, string place)
	{
		var friend = new Friend(name, place);
		Repository.Add(friend);
		return Index();
	}

}
