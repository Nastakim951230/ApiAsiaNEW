using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class ActorsModel
    {
        public ActorsModel(Actor actor)
        {
            IdActor = actor.IdActor;
            NameActor = actor.NameActor;
            DR_Actor = actor.DR_Actor;
            PhotoActor = actor.PhotoActor;
        }

        public int IdActor { get; set; }
        public string NameActor { get; set; }
        public System.DateTime DR_Actor { get; set; }
        public string PhotoActor { get; set; }
    }
}