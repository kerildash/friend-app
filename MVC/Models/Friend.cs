using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC.Models;

public class Friend
{

	public required Guid Id { get; set; }
	[Required(ErrorMessage = "Введите имя")]
	public required string Name { get; set; }
	[Required(ErrorMessage = "Введите город")]
	public required string Place { get; set; }


	[SetsRequiredMembers]
	public Friend(string name, string place)
	{
		Id = Guid.NewGuid();
		Name = name;
		Place = place;
	}
	[SetsRequiredMembers]
	public Friend() { }
}
