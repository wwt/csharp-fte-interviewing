namespace Api.Models;

public class Song
{
    public string Title { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Song song && Title == song.Title;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title);
    }
}
