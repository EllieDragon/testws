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
    
    public partial class composition_of_supply
    {
        public int supply_id { get; set; }
        public int goods_id { get; set; }
        public int count { get; set; }
    
        public virtual goods goods { get; set; }
        public virtual supply supply { get; set; }
    }
}
