

using EBookLibrary.Entity.Models;
using System;

namespace EBookLibrary.Models.Catalog
{
    public class CheckOutListingModel
    {
        public int id { get; set; }
        public LibraryAsset LibraryAsset { get; set; }
        public string FullName { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        public bool Confirm { get; set; }
    }
}
