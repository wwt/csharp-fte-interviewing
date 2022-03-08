namespace Data.Models;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Artist artist && Id == artist.Id && Name == artist.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }
}
