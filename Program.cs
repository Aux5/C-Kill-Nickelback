using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string song,string artist)> goodSongs = new List<(string song, string artist)>();
            List<(string song,string artist)> badSongs = new List<(string song, string artist)>();

            HashSet<(string song, string artist)> Allsongs = new HashSet<(string song, string artist)>();
            Allsongs.Add(("Photograph","NickelBack"));
            Allsongs.Add(("Someday","NickelBack"));
            Allsongs.Add(("How you Remind Me","NickelBack"));
            Allsongs.Add(("Glycerine","Bush"));
            Allsongs.Add(("SunLips","Black Moth Super Rainbow"));
            Allsongs.Add(("Jim Morison","Jon Bellion"));
            Allsongs.Add(("Mississippi Queen","Mountain"));
            Allsongs.Add(("Brighton Rock","Queen"));
            Allsongs.Add(("Spoonman","Soundgarden"));
            Allsongs.Add(("Omniverse","SURVIVE"));

            foreach (var item in Allsongs)
            {
                if(item.artist != "NickelBack"){
                    goodSongs.Add(item);
                } else{
                    badSongs.Add(item);
                }
            }
            foreach (var item in goodSongs)
            {
                Console.WriteLine($"{item.song} by {item.artist} is a good song");
            }
            foreach (var item in badSongs)
            {
                Console.WriteLine($"{item.song} by {item.artist} is a terrible song");
            }





        }
    }
}
