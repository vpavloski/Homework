using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string first, string last, int age, Genre favoriteMusic)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            FavoriteMusicType = favoriteMusic;
            
        }
        public Person()
        {
        }

        public void GetFavSongs()
        {   if (FavoriteSongs.Count > 0)
            {
                Console.WriteLine($"\n{FirstName} {LastName} likes these songs:");
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine($"{song.Title} {song.Length} {song.Genre}");
                }
            }
        else
            {
                Console.WriteLine($" \n{FirstName} {LastName} hates a music and dosn`t have a favorite song at all");
            }
        }

    }
}
