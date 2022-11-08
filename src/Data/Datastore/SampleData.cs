using Data.Models;

namespace Data.Datastore;

public static class SampleData
{
    public static Dictionary<int, AlbumEntity> Albums = new Dictionary<int, AlbumEntity>
    {
        {
            1,
            new AlbumEntity
            {
                ArtistId = 1,
                Id = 1,
                Title = "Nunc",
                ReleaseDate = 2011,
                SongIds = new List<int> { 1, 2, 4, 6 }
            }
        },
        {
            2,
            new AlbumEntity
            {
                ArtistId = 1,
                Id = 2,
                Title = "Biben",
                ReleaseDate = 1998,
                SongIds = new List<int> { 3, 5, 7 }
            }
        },
        {
            3,
            new AlbumEntity
            {
                ArtistId = 2,
                Id = 3,
                Title = "Diam",
                ReleaseDate = 2011,
                SongIds = new List<int> { 8, 9, 10, 11 }
            }
        },
        {
            4,
            new AlbumEntity
            {
                ArtistId = 1,
                Id = 4,
                Title = "EiUSMod",
                ReleaseDate = 2021,
                SongIds = new List<int> { 13, 12, 14, 15 }
            }
        },
        {
            5,
            new AlbumEntity
            {
                ArtistId = 3,
                Id = 5,
                Title = "SIT",
                ReleaseDate = 2006,
                SongIds = new List<int> { 21, 22, 24, 26 }
            }
        },
        {
            6,
            new AlbumEntity
            {
                ArtistId = 4,
                Id = 6,
                Title = "IPSUM",
                ReleaseDate = 2002,
                SongIds = new List<int> { 23, 25, 27 }
            }
        },
        {
            7,
            new AlbumEntity
            {
                ArtistId = 5,
                Id = 7,
                Title = "Sed DO eIus",
                ReleaseDate = 2002,
                SongIds = new List<int> { 31, 32, 34, 36 }
            }
        },
        {
            8,
            new AlbumEntity
            {
                ArtistId = 3,
                Id = 8,
                Title = "Dolor Sit",
                ReleaseDate = 2001,
                SongIds = new List<int> { 35, 32, 33, 34 }
            }
        },
    };

    public static Dictionary<int, ArtistEntity> Artists = new Dictionary<int, ArtistEntity>
    {
        {
            1,
            new ArtistEntity { Id = 1, Name = "Leanne Graham" }
        },
        {
            2,
            new ArtistEntity { Id = 2, Name = "Ervin Howell" }
        },
        {
            3,
            new ArtistEntity { Id = 3, Name = "Clementine Bauch" }
        },
        {
            4,
            new ArtistEntity { Id = 4, Name = "Patricia Lebsack" }
        },
        {
            5,
            new ArtistEntity { Id = 5, Name = "Chelsey Dietrich" }
        },
    };

    public static Dictionary<int, SongEntity> Songs = new Dictionary<int, SongEntity>
    {
        {
            1,
            new SongEntity { Title = "Lorem ipsum dolor", Id = 1, }
        },
        {
            2,
            new SongEntity { Title = "ipsum dolor sit amet", Id = 2, }
        },
        {
            3,
            new SongEntity { Title = "consectetur adipiscing elit", Id = 3, }
        },
        {
            4,
            new SongEntity { Title = "sed do eiusmod", Id = 4, }
        },
        {
            5,
            new SongEntity { Title = "adipiscing elit, sed do", Id = 5, }
        },
        {
            6,
            new SongEntity { Title = "incididunt ut labore", Id = 6, }
        },
        {
            7,
            new SongEntity { Title = "dolor sit amet, consectetur", Id = 7, }
        },
        {
            8,
            new SongEntity { Title = "ipsum dolor sit", Id = 8, }
        },
        {
            9,
            new SongEntity { Title = "sit amet", Id = 9, }
        },
        {
            10,
            new SongEntity { Title = "amet", Id = 10, }
        },
        {
            11,
            new SongEntity { Title = "consequat", Id = 11, }
        },
        {
            12,
            new SongEntity { Title = "lorem", Id = 12, }
        },
        {
            13,
            new SongEntity { Title = "neque egestas", Id = 13, }
        },
        {
            14,
            new SongEntity { Title = "A scelerisque purus semper eget", Id = 14, }
        },
        {
            15,
            new SongEntity { Title = "etiam tempor orci", Id = 15, }
        },
        {
            21,
            new SongEntity { Title = "eu", Id = 21, }
        },
        {
            22,
            new SongEntity { Title = "sed viverra", Id = 22, }
        },
        {
            23,
            new SongEntity { Title = "lorem", Id = 23, }
        },
        {
            24,
            new SongEntity { Title = "scelerisque", Id = 24, }
        },
        {
            25,
            new SongEntity { Title = "Amet facilisis", Id = 25, }
        },
        {
            26,
            new SongEntity { Title = "pellentesque eu tincidunt", Id = 26, }
        },
        {
            27,
            new SongEntity { Title = "Faucibus turpis", Id = 27, }
        },
        {
            30,
            new SongEntity { Title = "in eu mi", Id = 30, }
        },
        {
            31,
            new SongEntity { Title = "amet FacIlIsis", Id = 31, }
        },
        {
            32,
            new SongEntity { Title = "Ipsum Dolor", Id = 32, }
        },
        {
            33,
            new SongEntity { Title = "interdum", Id = 33, }
        },
        {
            34,
            new SongEntity { Title = "mi eu", Id = 34, }
        },
        {
            35,
            new SongEntity { Title = "Malesuada", Id = 35, }
        },
        {
            36,
            new SongEntity { Title = "Proin libEro", Id = 36, }
        },
        {
            37,
            new SongEntity { Title = "maluada", Id = 37, }
        },
    };
}
