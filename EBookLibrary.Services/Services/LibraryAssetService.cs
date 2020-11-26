

using EBookLibrary.Entity.Data;
using EBookLibrary.Entity.IServices;
using EBookLibrary.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EBookLibrary.Services.Services
{
    
    public class LibraryAssetService : ILibraryAssetService
    {

        private readonly EBookLibraryContext _context;
        public LibraryAssetService(EBookLibraryContext context)
        {
            _context = context;
        }
        public int Add(LibraryAsset model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return model.Id;
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(asset=>asset.Status)
                .Include(asset=>asset.Location);
        }

        public LibraryAsset GetById(int id)
        {
            var model = GetAll()
                .FirstOrDefault(x => x.Id == id);
            return model;
        }

        public void updateStatus(int id,int statusId)
        {
            var model = GetById(id);
            model.Status = _context.Statuses.FirstOrDefault(x=>x.Id==statusId);

            _context.LibraryAssets.Update(model);

            _context.SaveChanges();
        }
    }
}
