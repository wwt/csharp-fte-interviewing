using Data.Models;

namespace Data;

public interface IRepository
{
    List<Album> GetAllAlbums();

    List<Artist> GetAllArtists();

    List<Song> GetAllSongs();

    Album GetAlbum(int albumId);

    Artist GetArtist(int artistId);

    Song GetSong(int songId);
}

public class Repository : IRepository
{
    private readonly IDictionary<int, Album> _albums;
    private readonly IDictionary<int, Artist> _artists;
    private readonly IDictionary<int, Song> _songs;

    public Repository(
        IDictionary<int, Album> albums,
        IDictionary<int, Artist> artists,
        IDictionary<int, Song> songs
    )
    {
        _albums = albums;
        _artists = artists;
        _songs = songs;
    }

    public List<Album> GetAllAlbums()
    {
        throw new NotImplementedException();
    }

    public List<Artist> GetAllArtists()
    {
        throw new NotImplementedException();
    }

    public List<Song> GetAllSongs()
    {
        throw new NotImplementedException();
    }

    public Album GetAlbum(int albumId)
    {
        throw new NotImplementedException();
    }

    public Artist GetArtist(int artistId)
    {
        throw new NotImplementedException();
    }

    public Song GetSong(int songId)
    {
        throw new NotImplementedException();
    }
}
