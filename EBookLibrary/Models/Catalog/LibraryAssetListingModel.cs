

namespace EBookLibrary.Models.Catalog
{
    public class LibraryAssetListingModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }

        public int Year { get; set; } // Just store as an int for BC

        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
