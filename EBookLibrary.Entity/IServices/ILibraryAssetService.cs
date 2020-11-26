
using EBookLibrary.Entity.Models;
using System.Collections.Generic;

namespace EBookLibrary.Entity.IServices
{
   public interface ILibraryAssetService
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset GetById(int id);
        int Add(LibraryAsset model);
        void updateStatus(int id,int statusId);
    }
}
