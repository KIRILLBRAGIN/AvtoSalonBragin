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
    
    public partial class CarsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarsSet()
        {
            this.AvailabilitySet = new HashSet<AvailabilitySet>();
        }
    
        public int IdCar { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public long Price { get; set; }
        public string GosNumber { get; set; }
        public int Release_Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailabilitySet> AvailabilitySet { get; set; }
    }
}
