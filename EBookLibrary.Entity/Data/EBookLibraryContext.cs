

using EBookLibrary.Entity.Models;
using Microsoft.EntityFrameworkCore;


namespace EBookLibrary.Entity.Data
{
   public class EBookLibraryContext:DbContext
    {
        public EBookLibraryContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<LibraryBranch> LibraryBranches { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<LibraryAsset> LibraryAssets { get; set; }
        public DbSet<CheckOut> CheckOuts { get; set; }
    }
}
