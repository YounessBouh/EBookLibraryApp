

using System;
using System.ComponentModel.DataAnnotations;

namespace EBookLibrary.Entity.Models
{
    public class CheckOut
    {
        [Key]
        public int id { get; set; }
        public LibraryAsset LibraryAsset { get; set; }
        [Required]
        public string FullName { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        public bool Confirm { get; set; }
    }
}
