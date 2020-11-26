using EBookLibrary.Controllers;
using EBookLibrary.Entity.IServices;
using EBookLibrary.Entity.Models;
using EBookLibrary.Models.Catalog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EBookLibraryTest
{
   public class CatalogControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            //arrange
            var MockLibraryRepo = new Mock<ILibraryAssetService>();
            var MockcheckoutRepo = new Mock<ICheckOutService>();
            MockLibraryRepo.Setup(n => n.GetAll()).Returns(GetAllLibraries());

            var controller = new CatalogController(MockLibraryRepo.Object,MockcheckoutRepo.Object);

            //act
            var result = controller.Index();

            // assert

            var resultView = Assert.IsType<ViewResult>(result);
            var resultModel = Assert.IsType<LibraryAssetIndexModel>(resultView.ViewData.Model);
            Assert.Equal(3, resultModel.LibraryAssetListing.Count());

        }

        [Theory]
        [InlineData(1,100)]
        public void DetailsTest(int ValidItem,int NonValidItem)
        {
            //********************************** check the valid Id **********************************

            //arrange
            var MockLibraryRepo = new Mock<ILibraryAssetService>();
            var MockcheckoutRepo = new Mock<ICheckOutService>();
            var validId = ValidItem;

            MockLibraryRepo.Setup(n => n.GetById(ValidItem)).Returns(GetAllLibraries()
                           .FirstOrDefault(b=>b.Id==ValidItem));

            MockcheckoutRepo.Setup(r => r.GetAllById(ValidItem)).Returns(GetAllCheckout()
              .Where(x => x.LibraryAsset.Id == ValidItem));

            var controller = new CatalogController(MockLibraryRepo.Object,MockcheckoutRepo.Object);

            //act
            var result = controller.Details(ValidItem);

            //assert
            var resultView = Assert.IsType<ViewResult>(result);
            var resultModel = Assert.IsType<AssetDetailsModel>(resultView.ViewData.Model);
            Assert.Equal(ValidItem, resultModel.Id);
            Assert.Equal("C++ Step by Step", resultModel.Title);

            //********************************** check non valid Id **********************************

            //arrange
            var NonvalidId = NonValidItem;
            MockLibraryRepo.Setup(n => n.GetById(NonvalidId)).Returns(GetAllLibraries()
                           .FirstOrDefault(b => b.Id == NonvalidId));
           
            //act
            var NonValidResult = controller.Details(NonvalidId);

            //assert
            Assert.IsType<NotFoundResult>(NonValidResult);
        }

        [Fact]
        public void GetAllCheckoutTest()
        {
            //arrange
            var MockLibraryRepo = new Mock<ILibraryAssetService>();
            var MockcheckoutRepo = new Mock<ICheckOutService>();
            MockcheckoutRepo.Setup(r => r.GetAll()).Returns(GetAllCheckout());
            var controller = new CatalogController(MockLibraryRepo.Object,MockcheckoutRepo.Object);

            //act
            var result = controller.CheckOutHistory();

            //assert
            var resultView = Assert.IsType<ViewResult>(result);
            var resultModel = Assert.IsType<CheckOutIndexModel>(resultView.ViewData.Model);
            Assert.Equal(3,resultModel.checkOutHistoryModel.Count());
        }

        [Theory]
        [InlineData(1)]
        public void LostTest(int validId)
        {
            //arrange
            var MockLibraryRepo = new Mock<ILibraryAssetService>();
            var MockcheckoutRepo = new Mock<ICheckOutService>();

            var controller = new CatalogController(MockLibraryRepo.Object, MockcheckoutRepo.Object);

            var result = controller.Lost(validId);

            var resultView = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Details", resultView.ActionName);
        }


        private static IEnumerable<LibraryAsset> GetAllLibraries()
        {
            return new List<LibraryAsset>()
            {
                new LibraryAsset
                {
                     Id=1,
                     Author="John",
                     Title="C++ Step by Step",
                     Year=2020,
                     Cost=12,
                    ImageUrl="c++.jpg",

                    Status=new Status{
                        Id=2,Name="available" ,
                        Description="a library asset that is available"
                    },

                    Location=new LibraryBranch{
                     Id=1,
                     Address="Poznan Library",
                     Description="Good Book for C++ Developers",
                     Name="C++",
                     OpenDate=DateTime.Now,
                     Telephone="911882929",
                     ImageUrl="image1.png"
                    }
                },
                 new LibraryAsset
                {
                     Id=2,
                     Author="Anna",
                     Title="Python Step by Step",
                     Year=2019,
                     Cost=17,
                    ImageUrl="python.jpg",

                    Status=new Status{
                        Id=2,Name="available" ,
                        Description="a library asset that is available"
                    },

                    Location=new LibraryBranch{
                     Id=1,
                     Address="Poznan Library",
                     Description="Good Book for C++ Developers",
                     Name="C++",
                     OpenDate=DateTime.Now,
                     Telephone="911882929",
                     ImageUrl="image1.png"
                    }
                },
                  new LibraryAsset
                {
                     Id=3,
                     Author="Ahmed",
                     Title="Angular Step by Step",
                     Year=2018,
                     Cost=15,
                    ImageUrl="angular.jpg",

                    Status=new Status{
                        Id=2,Name="available" ,
                        Description="a library asset that is available"
                    },

                    Location=new LibraryBranch{
                     Id=1,
                     Address="Poznan Library",
                     Description="Good Book for C++ Developers",
                     Name="C++",
                     OpenDate=DateTime.Now,
                     Telephone="911882929",
                     ImageUrl="image1.png"
                    }
                }
            };
        }
        private static IEnumerable<CheckOut> GetAllCheckout()
        {
            return new List<CheckOut>()
            {
                new CheckOut
                {
                     id=1,
                     FullName="Youness",
                     Since=DateTime.Now,
                     Until=DateTime.Now.AddDays(2),
                     Confirm=false,
                     LibraryAsset=GetBook()
                },
                new CheckOut
                {
                     id=2,
                     FullName="Ahmed",
                     Since=DateTime.Now,
                     Until=DateTime.Now.AddDays(2),
                     Confirm=false,
                     LibraryAsset=GetBook()
                },
                new CheckOut
                {
                     id=3,
                     FullName="Karim",
                     Since=DateTime.Now,
                     Until=DateTime.Now.AddDays(2),
                     Confirm=false,
                     LibraryAsset=GetBook()
                }

            };
        }
        private static LibraryAsset GetBook()
        {
            return new LibraryAsset {
                Id = 1,
                Author = "John",
                Title = "C++ Step by Step",
                Year = 2020,
                Cost = 12,
                ImageUrl = "c++.jpg",

                Status = new Status
                {
                    Id = 2,
                    Name = "available",
                    Description = "a library asset that is available"
                },

                Location = new LibraryBranch
                {
                    Id = 1,
                    Address = "Poznan Library",
                    Description = "Good Book for C++ Developers",
                    Name = "C++",
                    OpenDate = DateTime.Now,
                    Telephone = "911882929",
                    ImageUrl = "image1.png"
                }
            };
        }
    }
}
