using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promotion
{
    public struct SKU_Item
    {
        public int price;
        public string SKU;
    }

    public partial class Form1 : Form
    {
        public char[] SKU_List = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public List<SKU_Item> SKU_PriceList = new List<SKU_Item>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < SKU_List.Length; i++)
            {
                SKU_Item SKU_Item = new SKU_Item();
                SKU_Item.SKU = SKU_List[i].ToString();
                SKU_Item.price = rnd.Next(0, 100);

                SKU_PriceList.Add(SKU_Item);
            }

            for (int i = 0; i < SKU_List.Length; i++)
                Combobox_SKU_List_For_Promotion.Items.Add(SKU_List[i]);
        }
    }
}
