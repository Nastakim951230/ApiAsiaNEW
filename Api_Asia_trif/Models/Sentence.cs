//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Asia_trif.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sentence
    {
        public int IdSentence { get; set; }
        public string NameKinoAndSerial { get; set; }
        public int Year { get; set; }
        public string PhotoKinoAndSerial { get; set; }
        public int Statys { get; set; }
        public int idUsers { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
