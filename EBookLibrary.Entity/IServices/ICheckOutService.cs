

using EBookLibrary.Entity.Models;
using System.Collections.Generic;

namespace EBookLibrary.Entity.IServices
{
    public interface ICheckOutService
    {
        IEnumerable<CheckOut> GetAll();
        IEnumerable<CheckOut> GetAllById(int id);
        CheckOut GetByLibraryAssetId(int id);
        void AddCheckOut(CheckOut checkOutModel);
        void ConfirmReturnedBook(int id);
    }
}
