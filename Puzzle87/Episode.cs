namespace Puzzle87;

public class Episode
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public string PublishDate { get; set; }
	public Episode(int id, string title, string description, string publishDate)
	{
		Id = id;
		Title = title;
		Description = description;
		PublishDate = publishDate;
	}
	public override string ToString()
	{
		return $"{Id}: {Title}";
	}
}
