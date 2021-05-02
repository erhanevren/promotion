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
        public List<String> SKU_List_In_A_New_Promotion = new List<String>();
        public List<String> Unique_SKUs_In_A_New_Promotion = new List<String>();
        public List<String> SKUs_In_Basket = new List<String>();
        public Basket basket = new Basket();

        int labelX = 10;
        int labelY = 20;
        int promotionNum = 0;
        PromotionObj promotion = new PromotionObj();

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            for (int i = 0; i < SKU_List.Length; i++)
            {
                SKU_Item SKU_Item = new SKU_Item();
                SKU_Item.SKU = SKU_List[i].ToString();
                SKU_Item.price = rnd.Next(10, 100);

                SKU_PriceList.Add(SKU_Item);
            }

            for (int i = 0; i < SKU_List.Length; i++)
                Combobox_SKU_List_For_Promotion.Items.Add(SKU_List[i]);

            for (int i = 0; i < SKU_List.Length; i++)
                Combobox_SKU_List_For_Basket.Items.Add(SKU_List[i] + " " + SKU_PriceList.Find(x => x.SKU == SKU_List[i].ToString()).price.ToString());

        }

        public void Select_SKU_For_Promotion(object sender, EventArgs e)
        {
            string SKU_Name = "";
            try
            {
                SKU_Name = Combobox_SKU_List_For_Promotion.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a SKU");
                //throw new Exception("Please select a SKU");
            }

            if (SKU_Name != "")
            {
                SKU_List_In_A_New_Promotion.Add(SKU_Name);
                SKU_List_In_A_New_Promotion = SKU_List_In_A_New_Promotion.OrderBy(x => x).ToList();

                Label labelTmp = new Label();
                labelTmp.Location = new Point(labelX, labelY);
                labelTmp.Width = 180;
                labelTmp.Text = String.Join(",", SKU_List_In_A_New_Promotion);

                if (groupBox_Selected_SKUs_For_Promotion.Controls.Count == 0)
                    groupBox_Selected_SKUs_For_Promotion.Controls.Add(labelTmp);
                else
                {
                    Label labelCurrentSKUs = (Label)groupBox_Selected_SKUs_For_Promotion.Controls[0];
                    labelCurrentSKUs.Text = labelTmp.Text;
                }

                Unique_SKUs_In_A_New_Promotion.Add(SKU_Name);
                Unique_SKUs_In_A_New_Promotion = Unique_SKUs_In_A_New_Promotion.OrderBy(x => x).Distinct().ToList();

                Combobox_SKU_For_Percentage.Items.Clear();
                Combobox_SKU_For_Percentage.Items.AddRange(Unique_SKUs_In_A_New_Promotion.ToArray());
            }
        }

        private void Clear_Selected_SKUs_For_Promotion(object sender, EventArgs e)
        {
            SKU_List_In_A_New_Promotion.Clear();
            groupBox_Selected_SKUs_For_Promotion.Controls.Clear();
            Unique_SKUs_In_A_New_Promotion.Clear();
            Combobox_SKU_For_Percentage.Items.Clear();
            Combobox_SKU_For_Percentage.ResetText();
            textBox_Fixed_Value.Text = "";
            textBox_Percentage_Value.Text = "";
        }

        public void Create_Promotion(object sender, EventArgs e)
        {
            if (SKU_List_In_A_New_Promotion.Count==0)
            {
                MessageBox.Show("Please select SKUs for promotion");
            }
            else if (radioButton1.Checked && textBox_Fixed_Value.Text == "")
            {
                MessageBox.Show("Please input fixed value for promotion");
            }
            else if (radioButton2.Checked && (textBox_Percentage_Value.Text == "" || Combobox_SKU_For_Percentage.SelectedIndex == -1))
            {
                MessageBox.Show("Please input percentage value and select SKU for percentage");
            }
            else
            {
                string SKU_combined = String.Join(",", SKU_List_In_A_New_Promotion);

                PromotionType promotionType = new PromotionType();
                promotionType.SKU_percentage = (radioButton2.Checked) ? Combobox_SKU_For_Percentage.SelectedItem.ToString() : "";
                promotionType.operand = (radioButton1.Checked) ? Convert.ToInt16(textBox_Fixed_Value.Text.ToString()) : Convert.ToInt16(textBox_Percentage_Value.Text.ToString());
                promotionType.operatorType = (radioButton1.Checked) ? "static" : "%";
                promotionType.operatorKey = SKU_List_In_A_New_Promotion.ToList();

                promotion.PromotionList.Add(promotionType);

                Label labelTmp = new Label();
                labelTmp.Text = SKU_combined + " => " + promotionType.operatorType + " " + promotionType.operand + " " + promotionType.SKU_percentage;
                labelTmp.Name = "promotion_" + promotionNum;
                int val = 20 + promotionNum * 20;
                labelTmp.Location = new Point(10, val);
                labelTmp.Size = new Size(150, 15);

                panel_Promotion_List.Controls.Add(labelTmp);
                labelTmp = null;
                promotionNum++;
            }

        }

        private void Select_SKU_For_Basket(object sender, EventArgs e)
        {
            string SKU_Name = "";
            try
            {
                SKU_Name = Combobox_SKU_List_For_Basket.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a SKU");
                //throw new Exception("Please select a SKU");
            }
            if (SKU_Name != "")
            {
                SKU_Name = SKU_Name.Substring(0, 1);
                SKUs_In_Basket.Add(SKU_Name);
                SKUs_In_Basket = SKUs_In_Basket.OrderBy(x => x).ToList();

                Label labelTmp = new Label();
                labelTmp.Location = new Point(labelX, labelY);
                labelTmp.Width = 180;
                labelTmp.Text = String.Join(",", SKUs_In_Basket);

                if (groupBox_Selected_SKUs_For_Basket.Controls.Count == 0)
                    groupBox_Selected_SKUs_For_Basket.Controls.Add(labelTmp);
                else
                {
                    Label labelCurrent = (Label)groupBox_Selected_SKUs_For_Basket.Controls[0];
                    labelCurrent.Text = labelTmp.Text;
                }
            }
        }

        private void Clear_Selected_SKUs_For_Basket(object sender, EventArgs e)
        {
            groupBox_Selected_SKUs_For_Basket.Controls.Clear();
            SKUs_In_Basket.Clear();
        }

        private void Clear_Promotions(object sender, EventArgs e)
        {
            promotion.PromotionList.Clear();
            panel_Promotion_List.Controls.Clear();
            promotionNum = 0;
        }

        private void ApplyPromotions(object sender, EventArgs e)
        {
            List<string> AppliedPromotions;
            int total = promotion.ApplyPromotion(basket, promotion.PromotionList, SKU_PriceList, out AppliedPromotions);
            int promotionNum = 0;
            Label labelTmp = new Label();
            int val = 0;
            foreach (String item in AppliedPromotions)
            {
                labelTmp = new Label();
                labelTmp.Text = item;
                labelTmp.Name = "result_" + promotionNum;
                val = 20 + promotionNum * 20;
                labelTmp.Location = new Point(10, val);
                labelTmp.Size = new Size(150, 15);

                panel_Result.Controls.Add(labelTmp);
                labelTmp = null;
                promotionNum++;
            }
            labelTmp = new Label();
            labelTmp.Text = "Total : " + total;
            labelTmp.Name = "result_" + promotionNum;
            val = 20 + promotionNum * 20;
            labelTmp.Location = new Point(10, val);
            labelTmp.Size = new Size(150, 15);

            panel_Result.Controls.Add(labelTmp);
            labelTmp = null;
        }

        private void CreateBasket(object sender, EventArgs e)
        {
            if (SKUs_In_Basket.Count == 0)
                MessageBox.Show("Please select a SKU for basket");
            else
            {
                int indx = 0;
                basket.BasketItemList.Clear();
                panel_Result.Controls.Clear();

                foreach (string SKU in SKUs_In_Basket)
                {
                    BasketItem item = new BasketItem();

                    indx++;
                    item.index = indx;
                    item.SKU = SKU.ToString();
                    item.price = SKU_PriceList.Find(x => x.SKU == SKU.ToString()).price;
                    basket.BasketItemList.Add(item);
                }
                label8.Text = String.Join(",", basket.BasketItemList.Select(x => x.SKU).ToList());
                label9.Text = String.Join(" + ", basket.BasketItemList.Select(x => x.price).ToList()) + " = " 
                    + basket.BasketItemList.Select(x => x.price).Sum().ToString();

                groupBox_Selected_SKUs_For_Basket.Controls.Clear();
                SKUs_In_Basket.Clear();
            }

        }
         
        private void Clear_Basket(object sender, EventArgs e)
        {
            label8.Text = "___";
            label9.Text = "___";
            basket.BasketItemList.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_SKU_For_Percentage.SelectedIndex = -1;
        }

        private void textBox_Fixed_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }             
        }

        private void textBox_Percentage_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
 
    }
}
