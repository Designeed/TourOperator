//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourOperator.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelPhotos
    {
        public int IdPhotoDirectory { get; set; }
        public int IdHotel { get; set; }
        public string PhotoDirectory { get; set; }
    
        public virtual HotelInformation HotelInformation { get; set; }
    }
}
