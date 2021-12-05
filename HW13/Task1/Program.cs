using System;
using System.Collections.Generic;
using HW13;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

Console.WriteLine("Input song genre");
string genreString = Console.ReadLine();
Enum.TryParse(genreString, out Genre genre);

var song = new Song("Song", 3, "Little Big", 2020, genre);
object data = GetSongData(song);
string s = SerializeByNewtonsoft(data);
Console.WriteLine(s);
string s2 = SerializeByMicrosoft(data);
Console.WriteLine(s2);

static string SerializeByNewtonsoft(object data) =>
    JsonConvert.SerializeObject(data, new StringEnumConverter());

static string SerializeByMicrosoft(object data) =>
    System.Text.Json.JsonSerializer.Serialize(data);

ISongService songService  = new SongService();
List<Song> result = songService.Search(genre);
Console.WriteLine(SerializeByMicrosoft(result));

static object GetSongData(Song song)
{
    var data = new 
    { 
        Title = song.Title,
        Minutes = song.Minutes,
        AlbumYear = song.AlbumYear,
        Genre = song.Genre
    };
    return data;
}

