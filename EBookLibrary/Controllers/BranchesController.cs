
using EBookLibrary.Entity.IServices;
using EBookLibrary.Models.Branche;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EBookLibrary.Controllers
{
    public class BranchesController : Controller
    {
        private readonly IBrancheService _IBrancheService;

        public BranchesController(IBrancheService IBrancheService)
        {
            _IBrancheService = IBrancheService;
        }
        public IActionResult Index()
        {
            var model = _IBrancheService.GetAll()
                     .Select(b => new BranchListingModel { 
                      Id=b.Id,
                      Name=b.Name,
                      Address=b.Address,
                      Description=b.Description,
                      ImageUrl=b.ImageUrl,
                      OpenDate=b.OpenDate,
                      Telephone=b.Telephone
                     });

            var brancheModel = new BranchIndexModel {
                ListingModels = model
            };
            return View(brancheModel);
        }
    }
}
