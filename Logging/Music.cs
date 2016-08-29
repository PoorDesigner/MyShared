using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Music : IMusic
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public List<Album> GetAlbumsByArtist(string name)
        {
            return new List<Album>() { new Album() { AlbumID = 1, AlbumName = "Album", Artist = name } };
        }
    }
}
