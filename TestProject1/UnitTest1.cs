using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using UnitMVC.Controllers;
using UnitMVC.DBContext;
using UnitMVC.Models;
using Xunit;

namespace TestProject1
{
    
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var book = new Book()
            {
                Name = "Test",
                Price = 23
            };
            var mockSet = new Mock<DbSet<Book>>();
            var mockContext = new Mock<MyDbContext>(new DbContextOptions<MyDbContext>());
            mockContext.Setup(m => m.books).Returns(mockSet.Object);
            var controller = new HomeController(mockContext.Object);

            var result = await controller.Create(book);

            //Asssert



            mockSet.Verify(x => x.Add(It.IsAny<Book>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            var redirectresult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectresult.ControllerName);
            Assert.Equal("Index", redirectresult.ActionName);

            //mockset.Verify(x => x.AddAsync(It.IsAny<Employee>(), default(CancellationToken)), Times.Once());
            //mockcontext.Verify(x => x.SaveChangesAsync(default(CancellationToken)), Times.Once());

            //var redirectresult = Assert.IsType<RedirectToActionResult>(result);
            //Assert.Null(redirectresult.ControllerName);
            //Assert.Equal("Index", redirectresult.ActionName);
        }
    }
}