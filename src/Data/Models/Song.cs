namespace Data.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Song song && Id == song.Id && Title == song.Title;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Title);
    }
}
