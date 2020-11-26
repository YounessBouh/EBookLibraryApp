using EBookLibrary.Controllers;
using EBookLibrary.Entity.IServices;
using EBookLibrary.Entity.Models;
using EBookLibrary.Models.Branche;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EBookLibraryTest
{
    public class BrancheControllerTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var MockRepo = new Mock<IBrancheService>();
            MockRepo.Setup(b => b.GetAll()).Returns(GetAllBranch());
            var controller = new BranchesController(MockRepo.Object);

            // act
            var result = controller.Index();

            // assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var viewResultModels = Assert.IsAssignableFrom<BranchIndexModel>(viewResult.ViewData.Model);
            Assert.Equal(4,viewResultModels.ListingModels.Count());

        }

        private static IEnumerable<LibraryBranch> GetAllBranch()
        {

            return new List<LibraryBranch>()
            {
                new LibraryBranch
                {
                     Id=1,
                     Address="Poznan Library",
                     Description="Good Book for C++ Developers",
                     Name="C++",
                     OpenDate=DateTime.Now,
                     Telephone="911882929",
                     ImageUrl="image1.png"
                },
                 new LibraryBranch
                {
                     Id=2,
                     Address="Wroclaw Library",
                     Description="Good Book for .Net Developers ",
                     Name="C#",
                     OpenDate=DateTime.Now,
                     Telephone="911882930",
                     ImageUrl="image2.png"

                },
                  new LibraryBranch
                {
                     Id=3,
                     Address="Warszawa Library",
                     Description="Good Book for Python Developers ",
                     Name="Python",
                     OpenDate=DateTime.Now,
                     Telephone="911882931",
                     ImageUrl="image3.png"
                },
                   new LibraryBranch
                {
                     Id=4,
                     Address="Gdansk Library",
                     Description="Good Book for Angular Developers ",
                     Name="Angular",
                     OpenDate=DateTime.Now,
                     Telephone="911882932",
                     ImageUrl="image4.png"
                }

            };
        }
    }
}
