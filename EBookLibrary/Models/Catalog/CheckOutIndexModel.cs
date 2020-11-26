
using System.Collections.Generic;

namespace EBookLibrary.Models.Catalog
{
    public class CheckOutIndexModel
    {
        public IEnumerable<CheckOutListingModel> checkOutHistoryModel { get; set; }
    }
}
