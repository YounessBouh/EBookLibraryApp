using EBookLibrary.Entity.Data;
using EBookLibrary.Entity.IServices;
using EBookLibrary.Entity.Models;
using System.Collections.Generic;

namespace EBookLibrary.Services.Services
{
    public class BrancheService : IBrancheService
    {
        private readonly EBookLibraryContext _context;
        public BrancheService(EBookLibraryContext context)
        {
            _context = context;    
        }
        public IEnumerable<LibraryBranch> GetAll()
        {
            return _context.LibraryBranches;
        }
    }
}
