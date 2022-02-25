using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class MusicFactory
    {
        public IMusicPlayer CreatePlayer(string playerType) => playerType switch
        {
            "cassette" => new CassettePlayer(),
            "streaming" => new StreamingService(),
            //_ => throw new NotImplementedException()
            _ => throw new NotImplementedException($"{playerType} is not supported")
        };
    }
}
