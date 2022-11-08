using Xunit;
using Api.Controllers;
using Api.Models;
using Data;
using Moq;
using System.Text.Json;
using System.Collections.Generic;
using Data.Models;

namespace Api.Test;

public class HomeControllerTests
{
    private readonly HomeController _testObject;
    private readonly Mock<IRepository> _mockRepository;

    public HomeControllerTests()
    {
        _mockRepository = new Mock<IRepository>();
        _testObject = new HomeController(_mockRepository.Object);
    }

    [Fact]
    public async void GetAlbumsByArtist_ReturnsEmptyListWhenArtistNotFound()
    {
        _mockRepository
            .Setup(m => m.GetAllAlbums())
            .Returns(
                new List<AlbumEntity>
                {
                    new AlbumEntity
                    {
                        ArtistId = 164,
                        ReleaseDate = 2001,
                        Title = "My new album",
                        SongIds = new List<int> { 1 }
                    },
                }
            );
        var actual = await _testObject.GetAlbumsByArtist(123);
        var expected = new List<Album>();

        Assert.Equal(expected, actual.Albums);
    }

    [Fact]
    public async void GetAlbumsByArtist_ReturnsAlbumsWhenArtistFound()
    {
        var expected = new GetAlbumsByArtistResponse
        {
            Albums = new List<Album>
            {
                new Album
                {
                    Artist = new Artist { Name = "No name person" },
                    ReleaseDate = 2001,
                    Title = "My new album",
                    Songs = new List<Song> { new Song { Title = "My first song" } }
                },
                new Album
                {
                    Artist = new Artist { Name = "No name person" },
                    ReleaseDate = 1901,
                    Title = "My oldest album",
                    Songs = new List<Song> { new Song { Title = "My second song" } }
                }
            }
        };
        var artistId = 164;
        var songId1 = 14;
        var songId2 = 578;
        _mockRepository
            .Setup(m => m.GetAllAlbums())
            .Returns(
                new List<AlbumEntity>
                {
                    new AlbumEntity
                    {
                        ArtistId = artistId,
                        ReleaseDate = 2001,
                        Title = "My new album",
                        SongIds = new List<int> { songId1 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 5473,
                        ReleaseDate = 2001,
                        Title = "Some other album",
                        SongIds = new List<int> { songId1 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = artistId,
                        ReleaseDate = 1901,
                        Title = "My oldest album",
                        SongIds = new List<int> { songId2 }
                    },
                }
            );
        _mockRepository
            .Setup(m => m.GetArtist(artistId))
            .Returns(new ArtistEntity { Id = artistId, Name = "No name person" });
        _mockRepository
            .Setup(m => m.GetSong(songId1))
            .Returns(new SongEntity { Id = songId1, Title = "My first song" });
        _mockRepository
            .Setup(m => m.GetSong(songId2))
            .Returns(new SongEntity { Id = songId2, Title = "My second song" });

        var actual = await _testObject.GetAlbumsByArtist(artistId);

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }

    [Fact]
    public async void SearchByAlbumName_ReturnsEmptyListWhenAlbumNotFound()
    {
        _mockRepository
            .Setup(m => m.GetAllAlbums())
            .Returns(
                new List<AlbumEntity>
                {
                    new AlbumEntity
                    {
                        ArtistId = 164,
                        ReleaseDate = 2001,
                        Title = "My new album",
                        SongIds = new List<int> { 123 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 5473,
                        ReleaseDate = 2011,
                        Title = "Some other album",
                        SongIds = new List<int> { 15 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 164,
                        ReleaseDate = 1985,
                        Title = "My other album",
                        SongIds = new List<int> { 5678 }
                    },
                }
            );
        var actual = await _testObject.SearchByAlbumName("not going to find it");
        var expected = new List<Album>();

        Assert.Equal(expected, actual.Albums);
    }

    [Fact]
    public async void SearchByAlbumName_ReturnsAlbumsWhenAlbumsFound()
    {
        var expected = new SearchByAlbumNameResponse
        {
            Albums = new List<Album>
            {
                new Album
                {
                    Artist = new Artist { Name = "Random person" },
                    ReleaseDate = 2011,
                    Title = "Some other album",
                    Songs = new List<Song> { new Song { Title = "My first song" } }
                },
                new Album
                {
                    Artist = new Artist { Name = "Unknown person" },
                    ReleaseDate = 1985,
                    Title = "My other album",
                    Songs = new List<Song> { new Song { Title = "My second song" } }
                },
            }
        };
        var songId1 = 14;
        var songId2 = 578;
        _mockRepository
            .Setup(m => m.GetAllAlbums())
            .Returns(
                new List<AlbumEntity>
                {
                    new AlbumEntity
                    {
                        ArtistId = 164,
                        ReleaseDate = 2001,
                        Title = "My new album",
                        SongIds = new List<int> { songId1 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 5473,
                        ReleaseDate = 2011,
                        Title = "Some other album",
                        SongIds = new List<int> { songId1 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 164,
                        ReleaseDate = 1985,
                        Title = "My other album",
                        SongIds = new List<int> { songId2 }
                    },
                }
            );
        _mockRepository
            .Setup(m => m.GetArtist(164))
            .Returns(new ArtistEntity { Id = 164, Name = "Unknown person" });
        _mockRepository
            .Setup(m => m.GetArtist(5473))
            .Returns(new ArtistEntity { Id = 5473, Name = "Random person" });
        _mockRepository
            .Setup(m => m.GetSong(songId1))
            .Returns(new SongEntity { Id = songId1, Title = "My first song" });
        _mockRepository
            .Setup(m => m.GetSong(songId2))
            .Returns(new SongEntity { Id = songId2, Title = "My second song" });

        var actual = await _testObject.SearchByAlbumName("OtHEr");

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }

    [Fact]
    public async void SearchBySongName_ReturnsEmptyListWhenSongDoNotMatch()
    {
        _mockRepository
            .Setup(m => m.GetAllSongs())
            .Returns(
                new List<SongEntity>
                {
                    new SongEntity { Title = "My first song", },
                    new SongEntity { Title = "My second song", },
                }
            );
        var actual = await _testObject.SearchBySongName("not going to find it");
        var expected = new List<Song>();

        Assert.Equal(expected, actual.Songs);
    }

    [Fact]
    public async void SearchBySongName_ReturnsSongsMatchingName()
    {
        var expected = new SearchBySongNameResponse
        {
            Songs = new List<Song> { new Song { Title = "One hit wonder", } }
        };

        _mockRepository
            .Setup(m => m.GetAllSongs())
            .Returns(
                new List<SongEntity>
                {
                    new SongEntity { Title = "My first song", },
                    new SongEntity { Title = "One hit wonder", },
                }
            );

        var actual = await _testObject.SearchBySongName("hIt");

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }

    [Fact]
    public async void GetAlbumsByYear_ReturnsEmptyListWhenNoAlbumsFound()
    {
        _mockRepository
            .Setup(m => m.GetAllAlbums())
            .Returns(
                new List<AlbumEntity>
                {
                    new AlbumEntity
                    {
                        ArtistId = 164,
                        ReleaseDate = 2001,
                        Title = "My new album",
                        SongIds = new List<int> { 1 }
                    },
                }
            );
        var actual = await _testObject.GetAlbumsByYear(1985);
        var expected = new List<Album>();

        Assert.Equal(expected, actual.Albums);
    }

    [Fact]
    public async void GetAlbumsByYear_ReturnsAlbumsWhenYearFound()
    {
        var expected = new GetAlbumsByYearResponse
        {
            Albums = new List<Album>
            {
                new Album
                {
                    Artist = new Artist { Name = "No name person" },
                    ReleaseDate = 2001,
                    Title = "My new album",
                    Songs = new List<Song> { new Song { Title = "My first song" } }
                },
                new Album
                {
                    Artist = new Artist { Name = "No name person" },
                    ReleaseDate = 2001,
                    Title = "Some other album",
                    Songs = new List<Song> { new Song { Title = "My first song" } }
                }
            }
        };
        var songId1 = 14;
        var songId2 = 578;

        _mockRepository
            .Setup(m => m.GetAllAlbums())
            .Returns(
                new List<AlbumEntity>
                {
                    new AlbumEntity
                    {
                        ArtistId = 123,
                        ReleaseDate = 2001,
                        Title = "My new album",
                        SongIds = new List<int> { songId1 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 123,
                        ReleaseDate = 2001,
                        Title = "Some other album",
                        SongIds = new List<int> { songId1 }
                    },
                    new AlbumEntity
                    {
                        ArtistId = 123,
                        ReleaseDate = 1901,
                        Title = "My oldest album",
                        SongIds = new List<int> { songId2 }
                    },
                }
            );
        _mockRepository
            .Setup(m => m.GetArtist(123))
            .Returns(new ArtistEntity { Id = 123, Name = "No name person" });
        _mockRepository
            .Setup(m => m.GetSong(songId1))
            .Returns(new SongEntity { Id = songId1, Title = "My first song" });
        _mockRepository
            .Setup(m => m.GetSong(songId2))
            .Returns(new SongEntity { Id = songId2, Title = "My second song" });

        var actual = await _testObject.GetAlbumsByYear(2001);

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }
}
