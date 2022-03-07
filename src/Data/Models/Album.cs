namespace Data.Models;

public class Album
{
    public int ArtistId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseDate { get; set; }
    public List<int> SongIds { get; set; }
}
