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
    
    public partial class KinoAndSerial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KinoAndSerial()
        {
            this.Comments = new HashSet<Comments>();
            this.KinoAndActor = new HashSet<KinoAndActor>();
            this.KinoAndGenre = new HashSet<KinoAndGenre>();
            this.KinoAndGroups = new HashSet<KinoAndGroups>();
        }
    
        public int IdKinoAndSerial { get; set; }
        public string Name { get; set; }
        public int idCountry { get; set; }
        public int YearKinoAndSerial { get; set; }
        public string TimeKinoAndSerial { get; set; }
        public string OKinoAndSerial { get; set; }
        public string PhotoKinoAndSerial { get; set; }
        public int OsnovnoeGanr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Country Country { get; set; }
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KinoAndActor> KinoAndActor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KinoAndGenre> KinoAndGenre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KinoAndGroups> KinoAndGroups { get; set; }
    }
}
