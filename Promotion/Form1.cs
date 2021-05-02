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

        int labelX = 10;
        int labelY = 20;
        int promotionNum = 0;
        Promotion promotion = new Promotion();

        public Form1()
        {
            InitializeComponent();

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

        private void Select_SKU_For_Promotion(object sender, EventArgs e)
        {
            string SKU_Name = "";
            try
            {
                SKU_Name = Combobox_SKU_List_For_Promotion.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a SKU");
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

        private void Create_Promotion(object sender, EventArgs e)
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

        private void Clear_Promotions(object sender, EventArgs e)
        {
            promotion.PromotionList.Clear();
            panel_Promotion_List.Controls.Clear();
            promotionNum = 0;
        }
          
    }
}
