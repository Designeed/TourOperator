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
    
    public partial class ToursRating
    {
        public int IdTourRating { get; set; }
        public int IdTour { get; set; }
        public int IdClient { get; set; }
        public string Comment { get; set; }
        public string Rating { get; set; }
        public int IdReview { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual ReviewType ReviewType { get; set; }
        public virtual Tours Tours { get; set; }
    }
}
