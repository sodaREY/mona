//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mona.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class марка_автомобиля
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public марка_автомобиля()
        {
            this.Автомобили = new HashSet<Автомобили>();
        }
    
        public int Код_марки { get; set; }
        public string Название_марки { get; set; }
        public string Страна_производитель { get; set; }
        public string Завод_производитель { get; set; }
        public string Адрес { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Автомобили> Автомобили { get; set; }
    }
}
