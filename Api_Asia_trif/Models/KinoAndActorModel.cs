using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class KinoAndActorModel
    {
        public KinoAndActorModel(KinoAndActor kinoAndActor)
        {
            IdKinoAndActor = kinoAndActor.IdKinoAndActor;
            IdKino=(int)kinoAndActor.IdKino;
            idActor=(int)kinoAndActor.idActor;
        }
        public int IdKinoAndActor { get; set; }
        public int IdKino { get; set; }
        public Nullable<int> idActor { get; set; }
    }
}