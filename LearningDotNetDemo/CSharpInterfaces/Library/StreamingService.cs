using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class StreamingService : IMusicPlayer
    {
        public string CurrentlyPlaying { get; set; }

        public void Play()
        {
            Console.WriteLine($"Currently Streaming: {CurrentlyPlaying} from the Internet");
        }
    }
}
