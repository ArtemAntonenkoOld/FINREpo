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
    
    public partial class tbCurrencyRate
    {
        public int cId { get; set; }
        public int cIdRate { get; set; }
        public int cIdCurrency { get; set; }
        public int cIdBank { get; set; }
    
        public virtual tbBank tbBank { get; set; }
        public virtual tbCurrency tbCurrency { get; set; }
        public virtual tbRate tbRate { get; set; }
    }
}