namespace Data.Models;

public class Album
{
    public int ArtistId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseDate { get; set; }
    public List<int> SongIds { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Album album
            && ArtistId == album.ArtistId
            && Id == album.Id
            && Title == album.Title
            && ReleaseDate == album.ReleaseDate
            && SongIds.SequenceEqual(album.SongIds);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ArtistId, Id, Title, ReleaseDate, SongIds);
    }
}
