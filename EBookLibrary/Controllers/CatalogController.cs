
using EBookLibrary.Entity.IServices;
using EBookLibrary.Entity.Models;
using EBookLibrary.Models.Catalog;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EBookLibrary.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILibraryAssetService _ILibraryAsset;
        private readonly ICheckOutService _ICheckOut;
        public CatalogController(ILibraryAssetService ILibraryAsset, ICheckOutService ICheckOut)
        {
            _ILibraryAsset = ILibraryAsset;
            _ICheckOut = ICheckOut;
        }
        public IActionResult Index()
        {
            var Items = _ILibraryAsset.GetAll()
                  .Select(asset => new LibraryAssetListingModel
                  {
                      Id = asset.Id,
                      Title = asset.Title,
                      Cost = asset.Cost,
                      Year = asset.Year,
                      ImageUrl = asset.ImageUrl,
                      Author=asset.Author

                  }) ;
            var model = new LibraryAssetIndexModel
            {
                LibraryAssetListing = Items
            };
            return View(model);
        }


        public IActionResult Details(int id)
        {
            var item = _ILibraryAsset.GetById(id);
            if(item==null)
            {
                return NotFound();
            }
            var model = new AssetDetailsModel { 
               Id=item.Id,
               Cost=item.Cost,
               ImageUrl=item.ImageUrl,
               Title = item.Title,
               Year=item.Year,
               status=item.Status.Name
            };

           model.checkOutHistory = GetAllById(id);
            return View(model);
        }

        public IActionResult Register(int id)
        {
            var RegModel = new RegisterIndexModel {
                id = id,
            };
            return View(RegModel);
        }

        public IActionResult CheckOut(RegisterIndexModel RegModel)
        {

            var LibraryAssetModel = _ILibraryAsset.GetById(RegModel.id);

            var model = new CheckOut {
                LibraryAsset = LibraryAssetModel,
                FullName = RegModel.FullName,
                Since = RegModel.Since,
                Until = RegModel.Untill.Date,
                Confirm = false
            };

            _ICheckOut.AddCheckOut(model);
            _ILibraryAsset.updateStatus(RegModel.id, 1);

            return RedirectToAction("Details", new { id = RegModel.id });
        }

        public IActionResult CheckIn(int id)
        {

            var checkOutModel = _ICheckOut.GetByLibraryAssetId(id);
            if(checkOutModel==null)
            {
                return RedirectToAction("Index");
            }


            _ILibraryAsset.updateStatus(id, 2);
            _ICheckOut.ConfirmReturnedBook(checkOutModel.id);

            return RedirectToAction("Details", new { id = id });
        }

        public IActionResult CheckOutHistory()
        {
            var Models = _ICheckOut.GetAll()
                              .Select(c => new CheckOutListingModel
                              {
                                  id = c.id,
                                  FullName = c.FullName,
                                  Confirm = c.Confirm,
                                  LibraryAsset = c.LibraryAsset,
                                  Since = c.Since,
                                  Until = c.Until
                              });
            var checkoutModel = new CheckOutIndexModel {
                checkOutHistoryModel = Models
            };

            return View(checkoutModel);
        }

        public IActionResult Lost(int id)
        {
            _ILibraryAsset.updateStatus(id, 3);
            return RedirectToAction("Details", new { id = id });
        }

        public IActionResult BookFound(int id)
        {
            _ILibraryAsset.updateStatus(id, 2);
            return RedirectToAction("Details",new { id=id});
        }

        private IEnumerable<CheckoutListingViewModel> GetAllById(int id)
        {
            var Item = _ICheckOut.GetAllById(id)
                       .Select(I=>new CheckoutListingViewModel { 
                        id=I.id,
                        FullName=I.FullName,
                        LibraryAsset=I.LibraryAsset,
                        Since=I.Since,
                        Until=I.Until,
                        Confirm=I.Confirm
                       });
         
            return Item;
        }
    }
}
