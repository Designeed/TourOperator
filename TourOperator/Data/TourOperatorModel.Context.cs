﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TourOperatorEntities : DbContext
    {
        public TourOperatorEntities()
            : base("name=TourOperatorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bascket> Bascket { get; set; }
        public virtual DbSet<CarrierCompany> CarrierCompany { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<HotelInformation> HotelInformation { get; set; }
        public virtual DbSet<HotelPhotos> HotelPhotos { get; set; }
        public virtual DbSet<HotelRoomPhotos> HotelRoomPhotos { get; set; }
        public virtual DbSet<HotelRooms> HotelRooms { get; set; }
        public virtual DbSet<HotelsRating> HotelsRating { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompany { get; set; }
        public virtual DbSet<PaidServices> PaidServices { get; set; }
        public virtual DbSet<ReviewType> ReviewType { get; set; }
        public virtual DbSet<ServicesCarrierCompany> ServicesCarrierCompany { get; set; }
        public virtual DbSet<ServicesInsuranceCompany> ServicesInsuranceCompany { get; set; }
        public virtual DbSet<ServicesRating> ServicesRating { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }
        public virtual DbSet<ToursRating> ToursRating { get; set; }
        public virtual DbSet<ToursReg> ToursReg { get; set; }
    }
}