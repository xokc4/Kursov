//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursov.bv
{
    using System;
    using System.Collections.Generic;
    
    public partial class Owner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Owner()
        {
            this.Apartment = new HashSet<Apartment>();
        }
    
        public int ID { get; set; }
        public string FullName { get; set; }
        public Nullable<int> Series { get; set; }
        public Nullable<int> Room { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DataBirth { get; set; }
        public string IssuedBy { get; set; }
        public Nullable<System.DateTime> DataIssue { get; set; }
        public Nullable<System.DateTime> DataRegistr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apartment> Apartment { get; set; }
    }
}
