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
    
    public partial class ToursReg
    {
        public int IdTour { get; set; }
        public int IdClient { get; set; }
        public int IdHotel { get; set; }
        public int IdHotelRoom { get; set; }
        public string PeopleNumber { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public int IdPaidServices { get; set; }
        public decimal TotalCost { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual HotelInformation HotelInformation { get; set; }
        public virtual HotelRooms HotelRooms { get; set; }
        public virtual PaidServices PaidServices { get; set; }
        public virtual Tours Tours { get; set; }
    }
}