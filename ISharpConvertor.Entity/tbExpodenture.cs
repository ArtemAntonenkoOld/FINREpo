//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISharpConvertor.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbExpodenture
    {
        public int cId { get; set; }
        public System.DateTime cTime { get; set; }
        public decimal cSume { get; set; }
        public string cCurrency { get; set; }
        public int cIdUser { get; set; }
    
        public virtual tbUser tbUser { get; set; }
    }
}