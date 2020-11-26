


using EBookLibrary.Entity.Models;
using System.Collections.Generic;

namespace EBookLibrary.Entity.IServices
{
    public interface IBrancheService
    {
        IEnumerable<LibraryBranch> GetAll();
    }
}
