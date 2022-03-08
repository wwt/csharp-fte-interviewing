namespace Api.Models;

public class Album
{
    public string Title { get; set; }

    public int ReleaseDate { get; set; }

    public Artist Artist { get; set; }

    public List<Song> Songs { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Album album
            && Title == album.Title
            && ReleaseDate == album.ReleaseDate
            && EqualityComparer<Artist>.Default.Equals(Artist, album.Artist)
            && EqualityComparer<List<Song>>.Default.Equals(Songs, album.Songs);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, ReleaseDate, Artist, Songs);
    }
}
