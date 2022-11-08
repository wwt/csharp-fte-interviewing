namespace Data.Models;

public class ArtistEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ArtistEntity artist && Id == artist.Id && Name == artist.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }
}
