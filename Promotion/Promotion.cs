using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion
{
    public struct PromotionType
    {
        public List<string> operatorKey; // A+A+B
        public string operatorType; // static or percentage
        public int operand; // static or percentage numeric value
        public string SKU_percentage; // SKU name if percentage is selected
    }

    public class PromotionObj
    {
        public List<PromotionType> PromotionList = new List<PromotionType>();

        public int ApplyPromotion(Basket basket, List<PromotionType> PromotionList, List<SKU_Item> SKU_PriceList, out List<string> AppliedPromotions)
        {
            AppliedPromotions = new List<string>();
            int total = 0;
            Basket basket_org = new Basket();
            basket_org.BasketItemList = basket.BasketItemList.ToList();
            bool promotionNotExists = false;

            foreach (PromotionType promotionType in PromotionList)
            {
                promotionNotExists = false;
                foreach (string SKU in promotionType.operatorKey)
                {
                    int basketItemIndx = basket.BasketItemList.FindIndex(x => x.SKU == SKU);

                    if (basketItemIndx >= 0)
                    {
                        basket.BasketItemList.RemoveAt(basketItemIndx);
                    }
                    else
                    {
                        basket.BasketItemList = basket_org.BasketItemList.ToList();
                        promotionNotExists = true;
                        break;
                    }
                }
                if (!promotionNotExists)
                {
                    string promotionStr = String.Join(",", promotionType.operatorKey) + " => " + promotionType.operatorType + " " + promotionType.operand + " " + promotionType.SKU_percentage;

                    if (promotionType.operatorType == "static")
                    {
                        total += promotionType.operand;
                        promotionStr += " : " + promotionType.operand;
                    }
                    else
                    {
                        int calculatedPercentage = SKU_PriceList.Find(x => x.SKU == promotionType.SKU_percentage).price * promotionType.operand / 100;
                        total += calculatedPercentage;
                        promotionStr += " : " + calculatedPercentage;
                    }
                    AppliedPromotions.Add(promotionStr);

                    basket_org.BasketItemList = basket.BasketItemList.ToList();
                }

            }
            foreach (BasketItem item in basket.BasketItemList)
            {
                total += item.price;
            }

            return total;
        }
    }

}