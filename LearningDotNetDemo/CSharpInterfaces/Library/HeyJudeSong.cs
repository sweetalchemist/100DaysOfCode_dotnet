using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class HeyJudeSong : IBeatleSong
    {
        public string SongName { get; set; } = "Hey Jude!";
        public string Author { get; set; } = "Lennon/McCartney";
        public void Play()
        {
            Console.WriteLine($"Playing {SongName} by {Author}");
        }
    }
}
