using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class KinoAndSerialsModel
    {
        private AsiaDrama_TrifonovaEntities db=new AsiaDrama_TrifonovaEntities();
        public KinoAndSerialsModel(KinoAndSerial kino)
        {
            IdKinoAndSerial=kino.IdKinoAndSerial;
            Name=kino.Name;
            idCountry=db.Country.ToList().FirstOrDefault(y=>y.IdCountry==kino.idCountry).NameCountry;
            YearKinoAndSerial=kino.YearKinoAndSerial;
            TimeKinoAndSerial =kino.TimeKinoAndSerial;
            OKinoAndSerial=kino.OKinoAndSerial;
            PhotoKinoAndSerial=kino.PhotoKinoAndSerial;
            OsnovnoeGanr = db.Genre.ToList().FirstOrDefault(y=>y.IdGenre==kino.OsnovnoeGanr).NameGenre;
        }

        public int IdKinoAndSerial { get; set; }
        public string Name { get; set; }
        public string idCountry { get; set; }
        public int YearKinoAndSerial { get; set; }
        public string TimeKinoAndSerial { get; set; }
        public string OKinoAndSerial { get; set; }
        public string PhotoKinoAndSerial { get; set; }
        public string OsnovnoeGanr { get; set; }
    }
}