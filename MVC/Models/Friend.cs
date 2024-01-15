using System.Diagnostics.CodeAnalysis;

namespace MVC.Models;

public class Friend
{
	public required Guid Id { get; set; }
	public string Name { get; set; }
	public required string Place { get; set; }

	[SetsRequiredMembers]
	public Friend(string name, string place)
	{
		Id = Guid.NewGuid();
		Name = name;
		Place = place;
	}
}
