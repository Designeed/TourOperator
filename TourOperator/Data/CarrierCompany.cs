//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourOperator.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarrierCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarrierCompany()
        {
            this.ServicesCarrierCompany = new HashSet<ServicesCarrierCompany>();
        }
    
        public int IdCarrierCompany { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesCarrierCompany> ServicesCarrierCompany { get; set; }
    }
}
