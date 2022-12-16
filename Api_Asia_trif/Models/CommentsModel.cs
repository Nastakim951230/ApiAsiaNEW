using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class CommentsModel
    {
        public CommentsModel(Comments comments)
        {
            IdComments = comments.IdComments;
            idUsers = (int)comments.idUsers;
            idKinoandSerial=(int)comments.idKinoandSerial;
            Comments1 = comments.Comments1;

        }
        public int IdComments { get; set; }
        public int idUsers { get; set; }
        public int idKinoandSerial { get; set; }
        public string Comments1 { get; set; }
    }

}