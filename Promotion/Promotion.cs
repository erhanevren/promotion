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

    public class Promotion
    {
        public List<PromotionType> PromotionList = new List<PromotionType>();
         
    }

}