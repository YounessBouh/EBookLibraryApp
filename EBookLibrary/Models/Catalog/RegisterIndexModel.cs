

using System;

namespace EBookLibrary.Models.Catalog
{
    public class RegisterIndexModel
    {
        public int id { get; set; }

        public string FullName { get; set; }
        public DateTime Since {get;set;}
        public DateTime Untill { get; set; }
    }
}
