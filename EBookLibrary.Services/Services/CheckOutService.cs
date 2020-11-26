

using EBookLibrary.Entity.Data;
using EBookLibrary.Entity.IServices;
using EBookLibrary.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EBookLibrary.Services.Services
{
    public class CheckOutService : ICheckOutService
    {
        private readonly EBookLibraryContext _context;

        public CheckOutService(EBookLibraryContext context)
        {
            _context = context;
        }

        public void AddCheckOut(CheckOut checkOutModel)
        {
            _context.CheckOuts.Add(checkOutModel);
            _context.SaveChanges();
        }

        public CheckOut GetByLibraryAssetId(int id)
        {
            var list = _context.CheckOuts.Include(c=>c.LibraryAsset).Where(c => c.LibraryAsset.Id == id).ToList();
            var item = list.LastOrDefault(ch=>ch.LibraryAsset.Id==id);
            return item;
        }

        public void ConfirmReturnedBook(int id)
        {
            var model = _context.CheckOuts.FirstOrDefault(c=>c.id==id);
            model.Confirm = true;
            _context.SaveChanges();
        }
        public IEnumerable<CheckOut> GetAll()
        {
            return _context.CheckOuts
                .Include(c=>c.LibraryAsset); ;
        }

        public IEnumerable<CheckOut> GetAllById(int id)
        {
            return GetAll().Where(ch => ch.LibraryAsset.Id == id);
        }
    }
}
