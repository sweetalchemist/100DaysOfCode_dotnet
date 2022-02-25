using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public interface IMusicPlayer
    {
        public string CurrentlyPlaying { get; set; }
        public void Play();
    }
}
