//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Childhood.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Educator
    {
        public int EducatorID { get; set; }
        public int EducatorEmployeeID { get; set; }
        public int EducatorGroupID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Groups Groups { get; set; }
    }
}