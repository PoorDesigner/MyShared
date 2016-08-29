using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public interface IMusic
    {
        List<Album> GetAlbumsByArtist(string name);

        int Add(int x, int y);
    }

}
