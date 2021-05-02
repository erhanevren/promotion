using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 ff = new Form1();
            //Assert.ThrowsException<System.FormatException>(() => ff.Create_Promotion(this, new EventArgs()));
        }

        [TestMethod]
        public void TestMethod2()
        {
            PromotionObj promotion = new PromotionObj();
            PromotionType promotionType = new PromotionType();
            promotionType.SKU_percentage = "A";
            promotionType.operand = 25;
            promotionType.operatorType = "%";
            promotionType.operatorKey = new List<string>() { "A", "B" };
            promotion.PromotionList.Add(promotionType);

            Assert.IsNotNull(promotion);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Form1 ff = new Form1();
            //Assert.ThrowsException<Exception>(() => ff.Select_SKU_For_Promotion(this, new EventArgs()));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Basket basket = new Basket();
            BasketItem basketItem1 = new BasketItem();
            basketItem1.SKU = "A";
            basketItem1.price = 50;
            basket.BasketItemList.Add(basketItem1);

            BasketItem basketItem2 = new BasketItem();
            basketItem2.SKU = "A";
            basketItem2.price = 50;
            basket.BasketItemList.Add(basketItem2);

            BasketItem basketItem3 = new BasketItem();
            basketItem3.SKU = "B";
            basketItem3.price = 60;
            basket.BasketItemList.Add(basketItem3);

            PromotionObj promotion = new PromotionObj();
            /*List<PromotionType> PromotionList = new List<PromotionType>();
            PromotionType promotionType = new PromotionType();
            promotionType.operand = 50;
            //promotionType.operatorKey = new List<string>();
            //promotionType.operatorKey.Add("A");
            promotionType.operatorType = "static";
            promotionType.SKU_percentage = "";
            promotion.PromotionList.Add(promotionType);*/

            List<SKU_Item> SKU_PriceList = new List<SKU_Item>();

            SKU_Item SKU_Item1 = new SKU_Item();
            SKU_Item1.SKU = "A";
            SKU_Item1.price = 50;
            SKU_PriceList.Add(SKU_Item1);

            SKU_Item SKU_Item2 = new SKU_Item();
            SKU_Item2.SKU = "B";
            SKU_Item2.price = 60;
            SKU_PriceList.Add(SKU_Item2);

            SKU_Item SKU_Item3 = new SKU_Item();
            SKU_Item3.SKU = "C";
            SKU_Item3.price = 40;
            SKU_PriceList.Add(SKU_Item3);

            List<string> AppliedPromotions;
            int total = promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions);

            Assert.AreEqual(160, total);
            //Assert.ThrowsException<NullReferenceException>(() => promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions));

        }

        [TestMethod]
        public void TestMethod5()
        {
            Basket basket = new Basket();
            BasketItem basketItem1 = new BasketItem();
            basketItem1.SKU = "A";
            basketItem1.price = 50;
            basket.BasketItemList.Add(basketItem1);

            BasketItem basketItem2 = new BasketItem();
            basketItem2.SKU = "A";
            basketItem2.price = 50;
            basket.BasketItemList.Add(basketItem2);

            BasketItem basketItem3 = new BasketItem();
            basketItem3.SKU = "B";
            basketItem3.price = 60;
            basket.BasketItemList.Add(basketItem3);

            PromotionObj promotion = new PromotionObj();
            List<PromotionType> PromotionList = new List<PromotionType>();
            PromotionType promotionType = new PromotionType();
            promotionType.operand = 20;
            promotionType.operatorKey = new List<string>();
            promotionType.operatorKey.Add("A");
            promotionType.operatorType = "static";
            promotionType.SKU_percentage = "";
            promotion.PromotionList.Add(promotionType);

            List<SKU_Item> SKU_PriceList = new List<SKU_Item>();

            SKU_Item SKU_Item1 = new SKU_Item();
            SKU_Item1.SKU = "A";
            SKU_Item1.price = 50;
            SKU_PriceList.Add(SKU_Item1);

            SKU_Item SKU_Item2 = new SKU_Item();
            SKU_Item2.SKU = "B";
            SKU_Item2.price = 60;
            SKU_PriceList.Add(SKU_Item2);

            SKU_Item SKU_Item3 = new SKU_Item();
            SKU_Item3.SKU = "C";
            SKU_Item3.price = 40;
            SKU_PriceList.Add(SKU_Item3);

            List<string> AppliedPromotions;
            int total = promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions);

            Assert.AreEqual(130, total);
            //Assert.ThrowsException<NullReferenceException>(() => promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions));

        }

        [TestMethod]
        public void TestMethod6()
        {
            Basket basket = new Basket();
            BasketItem basketItem1 = new BasketItem();
            basketItem1.SKU = "A";
            basketItem1.price = 50;
            basket.BasketItemList.Add(basketItem1);

            BasketItem basketItem2 = new BasketItem();
            basketItem2.SKU = "A";
            basketItem2.price = 50;
            basket.BasketItemList.Add(basketItem2);

            BasketItem basketItem3 = new BasketItem();
            basketItem3.SKU = "B";
            basketItem3.price = 60;
            basket.BasketItemList.Add(basketItem3);

            PromotionObj promotion = new PromotionObj();
            List<PromotionType> PromotionList = new List<PromotionType>();
            PromotionType promotionType = new PromotionType();
            promotionType.operand = 20;
            promotionType.operatorKey = new List<string>();
            promotionType.operatorKey.Add("A");
            promotionType.operatorType = "percentage";
            promotionType.SKU_percentage = "A";
            promotion.PromotionList.Add(promotionType);

            List<SKU_Item> SKU_PriceList = new List<SKU_Item>();

            SKU_Item SKU_Item1 = new SKU_Item();
            SKU_Item1.SKU = "A";
            SKU_Item1.price = 50;
            SKU_PriceList.Add(SKU_Item1);

            SKU_Item SKU_Item2 = new SKU_Item();
            SKU_Item2.SKU = "B";
            SKU_Item2.price = 60;
            SKU_PriceList.Add(SKU_Item2);

            SKU_Item SKU_Item3 = new SKU_Item();
            SKU_Item3.SKU = "C";
            SKU_Item3.price = 40;
            SKU_PriceList.Add(SKU_Item3);

            List<string> AppliedPromotions;
            int total = promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions);

            Assert.AreEqual(120, total);
            //Assert.ThrowsException<NullReferenceException>(() => promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions));

        }

        [TestMethod]
        public void TestMethod7()
        {
            Basket basket = new Basket();
            BasketItem basketItem1 = new BasketItem();
            basketItem1.SKU = "A";
            basketItem1.price = 50;
            basket.BasketItemList.Add(basketItem1);

            BasketItem basketItem2 = new BasketItem();
            basketItem2.SKU = "A";
            basketItem2.price = 50;
            basket.BasketItemList.Add(basketItem2);

            BasketItem basketItem3 = new BasketItem();
            basketItem3.SKU = "B";
            basketItem3.price = 60;
            basket.BasketItemList.Add(basketItem3);

            PromotionObj promotion = new PromotionObj();
            List<PromotionType> PromotionList = new List<PromotionType>();
            PromotionType promotionType = new PromotionType();
            promotionType.operand = 50;
            promotionType.operatorKey = new List<string>();
            promotionType.operatorKey.Add("A");
            promotionType.operatorKey.Add("A");
            promotionType.operatorKey.Add("B");
            promotionType.operatorType = "static";
            promotionType.SKU_percentage = "";
            promotion.PromotionList.Add(promotionType);

            List<SKU_Item> SKU_PriceList = new List<SKU_Item>();

            SKU_Item SKU_Item1 = new SKU_Item();
            SKU_Item1.SKU = "A";
            SKU_Item1.price = 50;
            SKU_PriceList.Add(SKU_Item1);

            SKU_Item SKU_Item2 = new SKU_Item();
            SKU_Item2.SKU = "B";
            SKU_Item2.price = 60;
            SKU_PriceList.Add(SKU_Item2);

            SKU_Item SKU_Item3 = new SKU_Item();
            SKU_Item3.SKU = "C";
            SKU_Item3.price = 40;
            SKU_PriceList.Add(SKU_Item3);

            List<string> AppliedPromotions;
            int total = promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions);

            Assert.AreEqual(50, total);
            //Assert.ThrowsException<NullReferenceException>(() => promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions));

        }
    }
}
