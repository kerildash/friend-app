using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services;


namespace MVC.Controllers;

public class FriendController : Controller
{
	public IFriendRepository Repository;
	public FriendController(IFriendRepository repository)
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
	public IActionResult Add([Bind(include: ["Id", "Name", "Place"])] Friend friend)
	{
		if (!ModelState.IsValid)
		{
			return View(friend);
		}
		Repository.Add(friend);	
		return RedirectToAction("Index");
	}
	[HttpGet]
	public IActionResult Edit(Guid id)
	{
		var friend = Repository.Get(id);
		return View(friend);
	}
	[HttpPost]
	public IActionResult Edit(Friend friend)
	{
		if (!ModelState.IsValid)
		{
			return View(friend);
		}
		Repository.Edit(friend);
		return RedirectToAction("Index");
	}
	[HttpGet]
	public IActionResult Delete(Guid id)
	{
		var friend = Repository.Get(id);
		return View(friend);
	}
	[HttpPost]
	public IActionResult Delete(Friend friend)
	{
		Repository.Delete(friend.Id);
		return RedirectToAction("");
	}
}