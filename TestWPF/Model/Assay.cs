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
    
    public partial class Assay
    {
        public int AssayID { get; set; }
        public int ProcessID { get; set; }
        public string AnimalStatus { get; set; }
        public string Diagnosis { get; set; }
    
        public virtual AnimalProcess AnimalProcess { get; set; }
    }
}