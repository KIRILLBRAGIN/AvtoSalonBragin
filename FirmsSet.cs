//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvtoSalon
{
    using System;
    using System.Collections.Generic;
    
    public partial class FirmsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FirmsSet()
        {
            this.AvailabilitySet = new HashSet<AvailabilitySet>();
        }
    
        public int IdFirm { get; set; }
        public string NameFirm { get; set; }
        public string Address_StreetHome { get; set; }
        public string Adress_City { get; set; }
        public string Phone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailabilitySet> AvailabilitySet { get; set; }
    }
}