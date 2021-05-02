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
            Assert.ThrowsException<System.FormatException>(() => ff.Create_Promotion(this, new EventArgs()));
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
    }
}
