using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC.Models;

public class Friend
{
	[Required(ErrorMessage = "Отсутствует ID")]
	public Guid Id { get; set; }

	[Required(ErrorMessage = "Введите имя: поле не может быть пустым")]
	public string Name { get; set; }

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
