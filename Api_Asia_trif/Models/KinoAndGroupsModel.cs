using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class KinoAndGroupsModel
    {
        private AsiaDrama_TrifonovaEntities db = new AsiaDrama_TrifonovaEntities();
        public KinoAndGroupsModel(KinoAndGroups kinoAndGroups)
        {
            IdKinoAndGroups = kinoAndGroups.IdKinoAndGroups;
            IdUsers=kinoAndGroups.IdUsers;
            IdKino=kinoAndGroups.IdKino;
            IdGroups=kinoAndGroups.IdGroups;

            Name = db.KinoAndSerial.ToList().FirstOrDefault(y => y.IdKinoAndSerial == kinoAndGroups.IdKino).Name;

            YearKinoAndSerial = db.KinoAndSerial.ToList().FirstOrDefault(y => y.IdKinoAndSerial == kinoAndGroups.IdKino).YearKinoAndSerial;
            PhotoKinoAndSerial = db.KinoAndSerial.ToList().FirstOrDefault(y => y.IdKinoAndSerial == kinoAndGroups.IdKino).PhotoKinoAndSerial;
            KinoAndSerial kino = db.KinoAndSerial.FirstOrDefault(x => x.IdKinoAndSerial == kinoAndGroups.IdKino);
            OsnovnoeGanr = db.Genre.ToList().FirstOrDefault(y => y.IdGenre == kino.OsnovnoeGanr).NameGenre;
        }
        public int IdKinoAndGroups { get; set; }
        public int IdUsers { get; set; }
        public int IdKino { get; set; }
        public int IdGroups { get; set; }

        public string Name { get; set; }
        public int YearKinoAndSerial { get; set; }
        public string PhotoKinoAndSerial { get; set; }
        public string OsnovnoeGanr { get; set; }
    }
}