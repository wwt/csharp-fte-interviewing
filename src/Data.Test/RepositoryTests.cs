using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Xunit;
using Data.Models;

namespace Data.Test;

public class RepositoryTests
{
    private readonly Repository _testObject;

    public RepositoryTests()
    {
        var albums = new List<Album>
        {
            new Album
            {
                ArtistId = 1,
                Id = 1,
                ReleaseDate = 2001,
                SongIds = new List<int> { 1, 2, 3 },
                Title = "Album 1"
            },
            new Album
            {
                ArtistId = 2,
                Id = 2,
                ReleaseDate = 2002,
                SongIds = new List<int> { 4, 5, 6 },
                Title = "Album 2"
            },
            new Album
            {
                ArtistId = 1,
                Id = 3,
                ReleaseDate = 2003,
                SongIds = new List<int> { 7, 8 },
                Title = "Album 3"
            },
        }.ToDictionary(el => el.Id);
        var artists = new List<Artist>
        {
            new Artist { Id = 1, Name = "Artist 1" },
            new Artist { Id = 2, Name = "Artist 2" },
        }.ToDictionary(el => el.Id);
        var songs = new List<Song>
        {
            new Song { Id = 1, Title = "Song 1" },
            new Song { Id = 2, Title = "Song 2" },
            new Song { Id = 3, Title = "Song 3" },
            new Song { Id = 4, Title = "Song 4" },
            new Song { Id = 5, Title = "Song 5" },
            new Song { Id = 6, Title = "Song 6" },
            new Song { Id = 7, Title = "Song 7" },
            new Song { Id = 8, Title = "Song 8" },
        }.ToDictionary(el => el.Id);
        _testObject = new Repository(albums, artists, songs);
    }

    [Fact]
    public void GetAllAlbums_ReturnsAllAlbums()
    {
        var expected = new List<Album>
        {
            new Album
            {
                ArtistId = 1,
                Id = 1,
                ReleaseDate = 2001,
                SongIds = new List<int> { 1, 2, 3 },
                Title = "Album 1"
            },
            new Album
            {
                ArtistId = 2,
                Id = 2,
                ReleaseDate = 2002,
                SongIds = new List<int> { 4, 5, 6 },
                Title = "Album 2"
            },
            new Album
            {
                ArtistId = 1,
                Id = 3,
                ReleaseDate = 2003,
                SongIds = new List<int> { 7, 8 },
                Title = "Album 3"
            },
        };
        var actual = _testObject.GetAllAlbums();

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }

    [Fact]
    public void GetAllArtists_ReturnsAllArtists()
    {
        var expected = new List<Artist>
        {
            new Artist { Id = 1, Name = "Artist 1" },
            new Artist { Id = 2, Name = "Artist 2" },
        };
        var actual = _testObject.GetAllArtists();

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }

    [Fact]
    public void GetAllSongs_ReturnsAllSongs()
    {
        var expected = new List<Song>
        {
            new Song { Id = 1, Title = "Song 1" },
            new Song { Id = 2, Title = "Song 2" },
            new Song { Id = 3, Title = "Song 3" },
            new Song { Id = 4, Title = "Song 4" },
            new Song { Id = 5, Title = "Song 5" },
            new Song { Id = 6, Title = "Song 6" },
            new Song { Id = 7, Title = "Song 7" },
            new Song { Id = 8, Title = "Song 8" },
        };
        var actual = _testObject.GetAllSongs();

        Assert.Equal(JsonSerializer.Serialize(expected), JsonSerializer.Serialize(actual));
    }

    [Fact]
    public void GetAlbum_ReturnsRequestedAlbum()
    {
        var expected = new Album
        {
            ArtistId = 2,
            Id = 2,
            ReleaseDate = 2002,
            SongIds = new List<int> { 4, 5, 6 },
            Title = "Album 2"
        };
        var actual = _testObject.GetAlbum(2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetArtist_ReturnsRequestedArtist()
    {
        var expected = new Artist { Id = 1, Name = "Artist 1" };
        var actual = _testObject.GetArtist(1);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSong_ReturnsRequestedSong()
    {
        var expected = new Song { Id = 7, Title = "Song 7" };
        var actual = _testObject.GetSong(7);

        Assert.Equal(expected, actual);
    }
}
