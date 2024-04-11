using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC.Models;

public class Friend
{
	[Required(ErrorMessage = "Отсутствует ID")]
	public Guid Id { get; set; }

	[Required(ErrorMessage = "Введите имя")]
	public string Name { get; set; }

	[Required(ErrorMessage = "Введите город")]
	[StringLength(25, ErrorMessage = "Допустимо не более 25 символов")]
	public string Place { get; set; }


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
