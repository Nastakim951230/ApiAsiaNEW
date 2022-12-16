using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class SentencesModel
    {
        public SentencesModel(Sentence sentence)
        {
            IdSentence = sentence.IdSentence;
            NameKinoAndSerial = sentence.NameKinoAndSerial;
            Year=sentence.Year;
            PhotoKinoAndSerial=sentence.PhotoKinoAndSerial;
            Statys=sentence.Statys;
            idUsers=sentence.idUsers;
        }

        public int IdSentence { get; set; }
        public string NameKinoAndSerial { get; set; }
        public int Year { get; set; }
        public string PhotoKinoAndSerial { get; set; }
        public int Statys { get; set; }
        public int idUsers { get; set; }
    }
}