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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Educator = new HashSet<Educator>();
        }
    
        public int EmployeeID { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeFathername { get; set; }
        public int EmployeeUserID { get; set; }
        public int EmployeeNumPassportdata { get; set; }
        public int EmployeeSeriaPassportdata { get; set; }
        public string EmployeeTelephoneNumber { get; set; }
        public string EmployeeEmail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Educator> Educator { get; set; }
        public virtual User User { get; set; }
    }
}
