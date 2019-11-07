using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseInMemory.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public int ArtistaID { get; set; }
        public Artista Artista { get; set; }

        public string Titulo { get; set; }
        public double Precio { get; set; }
    }
}
