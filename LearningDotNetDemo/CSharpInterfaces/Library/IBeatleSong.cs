using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public interface IBeatleSong
    {
        public string SongName { get; set; }
        public string Author { get; set; }
        public void Play();
    }
}
