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
    
    public partial class Продажа_автомобилей
    {
        public int Код_автомобиля { get; set; }
        public System.DateTime Дата { get; set; }
        public int Сотрудник { get; set; }
        public int Автомобиль { get; set; }
        public int Покупатель { get; set; }
    
        public virtual Автомобили Автомобили { get; set; }
        public virtual Покупатели Покупатели { get; set; }
        public virtual Сотрудник Сотрудник1 { get; set; }
    }
}
