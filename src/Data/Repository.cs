using Data.Models;

namespace Data;

public interface IRepository
{
    List<AlbumEntity> GetAllAlbums();

    List<ArtistEntity> GetAllArtists();

    List<SongEntity> GetAllSongs();

    AlbumEntity GetAlbum(int albumId);

    ArtistEntity GetArtist(int artistId);

    SongEntity GetSong(int songId);
}

public class Repository : IRepository
{
    private readonly IDictionary<int, AlbumEntity> _albums;
    private readonly IDictionary<int, ArtistEntity> _artists;
    private readonly IDictionary<int, SongEntity> _songs;

    public Repository(
        IDictionary<int, AlbumEntity> albums,
        IDictionary<int, ArtistEntity> artists,
        IDictionary<int, SongEntity> songs
    )
    {
        _albums = albums;
        _artists = artists;
        _songs = songs;
    }

    public List<AlbumEntity> GetAllAlbums()
    {
        throw new NotImplementedException();
    }

    public List<ArtistEntity> GetAllArtists()
    {
        throw new NotImplementedException();
    }

    public List<SongEntity> GetAllSongs()
    {
        throw new NotImplementedException();
    }

    public AlbumEntity GetAlbum(int albumId)
    {
        throw new NotImplementedException();
    }

    public ArtistEntity GetArtist(int artistId)
    {
        throw new NotImplementedException();
    }

    public SongEntity GetSong(int songId)
    {
        throw new NotImplementedException();
    }
}
