//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWPF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AviaryProcess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AviaryProcess()
        {
            this.Cleaning = new HashSet<Cleaning>();
            this.Repair = new HashSet<Repair>();
        }
    
        public int AviaryProcessID { get; set; }
        public int AviaryID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Aviary Aviary { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cleaning> Cleaning { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Repair> Repair { get; set; }
    }
}
