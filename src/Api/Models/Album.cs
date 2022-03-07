namespace Api.Models;

public class Album
{
    public string Title { get; set; }

    public int ReleaseDate { get; set; }

    public Artist Artist { get; set; }

    public List<Song> Songs { get; set; }
}
