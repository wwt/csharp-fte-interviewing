namespace Api.Models;

public class Artist
{
    public string Name { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Artist artist && Name == artist.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}
