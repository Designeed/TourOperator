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
    
    public partial class HotelRooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HotelRooms()
        {
            this.HotelRoomPhotos = new HashSet<HotelRoomPhotos>();
            this.ToursReg = new HashSet<ToursReg>();
        }
    
        public int IdHotelRoom { get; set; }
        public int IdHotel { get; set; }
        public int RoomNumber { get; set; }
        public string RoomStar { get; set; }
        public decimal CostRoomDay { get; set; }
        public string ReservationType { get; set; }
        public int SeatsNumber { get; set; }
        public string Equipment { get; set; }
    
        public virtual HotelInformation HotelInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRoomPhotos> HotelRoomPhotos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToursReg> ToursReg { get; set; }
    }
}
