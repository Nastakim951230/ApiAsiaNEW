using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class KinoAndGroupsModel
    {
        public KinoAndGroupsModel(KinoAndGroups kinoAndGroups)
        {
            IdKinoAndGroups = kinoAndGroups.IdKinoAndGroups;
            IdUsers=kinoAndGroups.IdUsers;
            IdKino=kinoAndGroups.IdKino;
            IdGroups=kinoAndGroups.IdGroups;
        }
        public int IdKinoAndGroups { get; set; }
        public int IdUsers { get; set; }
        public int IdKino { get; set; }
        public int IdGroups { get; set; }
    }
}