using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock TestStock = new clsStock();
            Assert.IsNotNull(TestStock);
        }

        [TestMethod]
        public void StockNameOK()
        {
            clsStock TestStock = new clsStock();
            string TestData = "GTX 1080";
            TestStock.Stock = TestData;
            Assert.AreEqual(TestStock.Stock, TestData);
        }

        [TestMethod]
        public void StockLevelOK()
        {
            clsStock TestStock = new clsStock();
            int stocklevel = 1;
            TestStock.stockLevel = stocklevel ;
            Assert.AreEqual(TestStock.stockLevel, stocklevel);
        }





        [TestMethod]
        public void ValidExists()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("GTX 1080");
            Assert.IsTrue(OK);
            
        }

        [TestMethod]
        public void ValidExistsStocklevel()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid2(0);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockLevelminlessone()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid2(0);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockLevelmax()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid2(100);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockLevelminminusone()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid2(-1);
            Assert.IsFalse(OK);

        }




        [TestMethod]
        public void StockNameMinLessOne()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("");
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StockMinPlusOne()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("ab");
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockMin()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("a");
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockMaxMinusOne()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("ahsnfhthfnajskfnshdngrehwushtngfighipandshitpgiod");
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockMax()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("abjfndkfjgnfmgnfjgnfmgktmewignrjajsndjcnfdotpgiltl");
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockMaxPlusOne()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("ahsjtigjthnklawheithasjwuftownfhcjakleyhsnfujlajsn1");
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StockMid()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            OK = TestStock.valid("ajajajajajajajajajajajaja");
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockExtremeMax()
        {
            clsStock TestStock = new clsStock();
            Boolean OK;
            string TestData = "";
            TestData = TestData.PadRight(500, 'a');
            OK = TestStock.valid(TestData);
            Assert.IsFalse(OK);

        }


    }
}
