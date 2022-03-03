using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class SomethingSong : IBeatleSong
    {
        public string SongName { get; set; } = "Something!";
        public string Author { get; set; } = "Harisson";
        public void Play()
        {
            Console.WriteLine($"Playing {SongName} by {Author}");
        }
    }
}
