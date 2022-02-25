using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class CassettePlayer : IMusicPlayer
    {
        public string CurrentlyPlaying { get; set; }

        public void Play()
        {
            Console.WriteLine($"Currently Playing: {CurrentlyPlaying} from the Cassette");
        }
    }
}
