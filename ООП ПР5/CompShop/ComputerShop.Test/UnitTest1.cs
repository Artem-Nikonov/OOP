using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerShop.Data.Sql;
using System.Linq;
using ComputerShop.Data.Memory;
using ComputerShop.Bll;
namespace ComputerShop.Test

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod(), TestCategory("Integration")]
        public void Sell_NewBook_CheckCreatedInDb()
        {
            // Arrange
            var bookData = new ComputerSqlData();
            var checkData = new CheckSqlData();
            var shop = new Shop(bookData, checkData);

            var book = new Computer
            {
                Firm = "TestAuthor",
                Name = "TestName",
                Price = 100,
                Quantity= 1,
            };

            // Act
            shop.Add(book);
            var books = shop.GetAllComputers().ToList();
            var check = shop.Sell(book);

            // Assert
            Assert.IsNotNull(books);
            Assert.IsNotNull(check);
        }

        [TestMethod(), TestCategory("Unit")]
        public void Sell_NewBook_CheckCreatedInMemory()
        {
            // Arrange
            var compData = new ComputerMemoryData();
            var checkData = new CheckMemoryData();
            var shop = new Shop(compData, checkData);

            var comp = new Computer
            {
                Firm = "TestFirm",
                Name = "TestName",
                Price = 1000,
                Quantity= 1,
            };

            // Act
            shop.Add(comp);
            var comps = shop.GetAllComputers().ToList();
            var check = shop.Sell(comp);

            // Assert
            Assert.IsNotNull(comps);
            Assert.IsNotNull(check);
        }
    }
}