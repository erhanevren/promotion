using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion
{
    public struct BasketItem
    {
        public string SKU;
        public int price;
        public int index;
    }

    public class Basket
    {
        public List<BasketItem> BasketItemList = new List<BasketItem>();
    }
}
