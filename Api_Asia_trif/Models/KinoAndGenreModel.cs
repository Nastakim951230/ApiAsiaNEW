using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class KinoAndGenreModel
    {
        public KinoAndGenreModel(KinoAndGenre kinoAndGenre)
        {
            IdKinoAndGenre = kinoAndGenre.IdKinoAndGenre;
            idKino=(int)kinoAndGenre.idKino;
            idGenre =(int) kinoAndGenre.idGenre;
        }
        public int IdKinoAndGenre { get; set; }
        public int idKino { get; set; }
        public int idGenre { get; set; }
    }
}