//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zooshop
{
    using System;
    using System.Collections.Generic;
    
    public partial class goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public goods()
        {
            this.composition_of_purchase = new HashSet<composition_of_purchase>();
            this.composition_of_supply = new HashSet<composition_of_supply>();
        }
    
        public int goods_id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<composition_of_purchase> composition_of_purchase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<composition_of_supply> composition_of_supply { get; set; }
    }
}