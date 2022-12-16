using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class GroupsModel
    {
        public GroupsModel(Groups groups)
        {
            IdGroups = groups.IdGroups;
            NameGroups = groups.NameGroups;
        }
        public int IdGroups { get; set; }
        public string NameGroups { get; set; }
    }
}