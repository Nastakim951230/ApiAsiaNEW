using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class GenreModel
    {
        public GenreModel(Genre genre)
        {
            IdGenre = genre.IdGenre;
            NameGenre = genre.NameGenre;
        }
        public int IdGenre { get; set; }
        public string NameGenre { get; set; }
    }
}