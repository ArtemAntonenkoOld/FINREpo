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
    
    public partial class tbRssUserNews
    {
        public int cId { get; set; }
        public int cIdUser { get; set; }
        public int cIdNews { get; set; }
    
        public virtual tbNews tbNews { get; set; }
        public virtual tbRssUser tbRssUser { get; set; }
    }
}
