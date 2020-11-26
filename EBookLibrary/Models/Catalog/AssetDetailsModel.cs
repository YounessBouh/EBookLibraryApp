

using System.Collections.Generic;

namespace EBookLibrary.Models.Catalog
{
    public class AssetDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string status { get; set; }
        public int Year { get; set; } 
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<CheckoutListingViewModel> checkOutHistory { get; set; }
    }
}
