using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopWithUs.Class;

namespace TestShopWithUs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoDiscountForOneItem()
        {
            Item[] listofItem = new Item[1];
            listofItem[0] = new Item("1001", "1001.1", 99.50);

            order o = new order();

            double totalBill = o.totalbill(listofItem);

            Assert.AreEqual(listofItem[0].cost, totalBill);
        }

        [TestMethod]
        public void CountTotalAmountOfPurchase()
        {
            Item[] listofItem = new Item[3];
            listofItem[0] = new Item("1001", "1001.1", 100.00);
            listofItem[1] = new Item("1001", "1001.2", 100.00);
            listofItem[2] = new Item("1001", "1001.3", 100.00);
            
            
        }
    }
}
