using Data.Models;

namespace Data.Datastore;

public static class SampleData
{
    public static Dictionary<int, Album> Albums = new Dictionary<int, Album>
    {
        {
            1,
            new Album
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
            new Album
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
            new Album
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
            new Album
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
            new Album
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
            new Album
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
            new Album
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
            new Album
            {
                ArtistId = 3,
                Id = 8,
                Title = "Dolor Sit",
                ReleaseDate = 2001,
                SongIds = new List<int> { 35, 32, 33, 34 }
            }
        },
    };

    public static Dictionary<int, Artist> Artists = new Dictionary<int, Artist>
    {
        {
            1,
            new Artist { Id = 1, Name = "Leanne Graham" }
        },
        {
            2,
            new Artist { Id = 2, Name = "Ervin Howell" }
        },
        {
            3,
            new Artist { Id = 3, Name = "Clementine Bauch" }
        },
        {
            4,
            new Artist { Id = 4, Name = "Patricia Lebsack" }
        },
        {
            5,
            new Artist { Id = 5, Name = "Chelsey Dietrich" }
        },
    };

    public static Dictionary<int, Song> Songs = new Dictionary<int, Song>
    {
        {
            1,
            new Song { Title = "Lorem ipsum dolor", Id = 1, }
        },
        {
            2,
            new Song { Title = "ipsum dolor sit amet", Id = 2, }
        },
        {
            3,
            new Song { Title = "consectetur adipiscing elit", Id = 3, }
        },
        {
            4,
            new Song { Title = "sed do eiusmod", Id = 4, }
        },
        {
            5,
            new Song { Title = "adipiscing elit, sed do", Id = 5, }
        },
        {
            6,
            new Song { Title = "incididunt ut labore", Id = 6, }
        },
        {
            7,
            new Song { Title = "dolor sit amet, consectetur", Id = 7, }
        },
        {
            8,
            new Song { Title = "ipsum dolor sit", Id = 8, }
        },
        {
            9,
            new Song { Title = "sit amet", Id = 9, }
        },
        {
            10,
            new Song { Title = "amet", Id = 10, }
        },
        {
            11,
            new Song { Title = "consequat", Id = 11, }
        },
        {
            12,
            new Song { Title = "lorem", Id = 12, }
        },
        {
            13,
            new Song { Title = "neque egestas", Id = 13, }
        },
        {
            14,
            new Song { Title = "A scelerisque purus semper eget", Id = 14, }
        },
        {
            15,
            new Song { Title = "etiam tempor orci", Id = 15, }
        },
        {
            21,
            new Song { Title = "eu", Id = 21, }
        },
        {
            22,
            new Song { Title = "sed viverra", Id = 22, }
        },
        {
            23,
            new Song { Title = "lorem", Id = 23, }
        },
        {
            24,
            new Song { Title = "scelerisque", Id = 24, }
        },
        {
            25,
            new Song { Title = "Amet facilisis", Id = 25, }
        },
        {
            26,
            new Song { Title = "pellentesque eu tincidunt", Id = 26, }
        },
        {
            27,
            new Song { Title = "Faucibus turpis", Id = 27, }
        },
        {
            30,
            new Song { Title = "in eu mi", Id = 30, }
        },
        {
            31,
            new Song { Title = "amet FacIlIsis", Id = 31, }
        },
        {
            32,
            new Song { Title = "Ipsum Dolor", Id = 32, }
        },
        {
            33,
            new Song { Title = "interdum", Id = 33, }
        },
        {
            34,
            new Song { Title = "mi eu", Id = 34, }
        },
        {
            35,
            new Song { Title = "Malesuada", Id = 35, }
        },
        {
            36,
            new Song { Title = "Proin libEro", Id = 36, }
        },
        {
            37,
            new Song { Title = "maluada", Id = 37, }
        },
    };
}
