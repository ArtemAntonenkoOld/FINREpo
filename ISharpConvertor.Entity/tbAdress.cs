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
    
    public partial class tbAdress
    {
        public tbAdress()
        {
            this.tbComins = new HashSet<tbComins>();
            this.tbRssUser = new HashSet<tbRssUser>();
        }
    
        public int cId { get; set; }
        public string cAdressVal { get; set; }
        public int cIdBank { get; set; }
        public string cStreet { get; set; }
        public string cCity { get; set; }
        public string cCountry { get; set; }
        public string cLongitude { get; set; }
        public string cLatitude { get; set; }
    
        public virtual tbBank tbBank { get; set; }
        public virtual ICollection<tbComins> tbComins { get; set; }
        public virtual ICollection<tbRssUser> tbRssUser { get; set; }
    }
}
