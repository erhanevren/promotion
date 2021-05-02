namespace Promotion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Promotion_List = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Selected_SKUs_For_Promotion = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Fixed_Value = new System.Windows.Forms.TextBox();
            this.textBox_Percentage_Value = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Combobox_SKU_For_Percentage = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.Combobox_SKU_List_For_Promotion = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel_Result = new System.Windows.Forms.Panel();
            this.groupBox_Selected_SKUs_For_Basket = new System.Windows.Forms.GroupBox();
            this.Combobox_SKU_List_For_Basket = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel_Promotion_List);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox_Selected_SKUs_For_Promotion);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Combobox_SKU_List_For_Promotion);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 431);
            this.panel1.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Clear promotions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Clear_Promotions);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Promotion List";
            // 
            // panel_Promotion_List
            // 
            this.panel_Promotion_List.AutoScroll = true;
            this.panel_Promotion_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Promotion_List.Location = new System.Drawing.Point(9, 293);
            this.panel_Promotion_List.Name = "panel_Promotion_List";
            this.panel_Promotion_List.Size = new System.Drawing.Size(287, 124);
            this.panel_Promotion_List.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "PROMOTION PANEL";
            // 
            // groupBox_Selected_SKUs_For_Promotion
            // 
            this.groupBox_Selected_SKUs_For_Promotion.Location = new System.Drawing.Point(9, 85);
            this.groupBox_Selected_SKUs_For_Promotion.Name = "groupBox_Selected_SKUs_For_Promotion";
            this.groupBox_Selected_SKUs_For_Promotion.Size = new System.Drawing.Size(189, 49);
            this.groupBox_Selected_SKUs_For_Promotion.TabIndex = 11;
            this.groupBox_Selected_SKUs_For_Promotion.TabStop = false;
            this.groupBox_Selected_SKUs_For_Promotion.Text = "Selected SKUs For Promotion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Fixed_Value);
            this.groupBox2.Controls.Add(this.textBox_Percentage_Value);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.Combobox_SKU_For_Percentage);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(9, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 111);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "%";
            // 
            // textBox_Fixed_Value
            // 
            this.textBox_Fixed_Value.Location = new System.Drawing.Point(113, 22);
            this.textBox_Fixed_Value.Name = "textBox_Fixed_Value";
            this.textBox_Fixed_Value.Size = new System.Drawing.Size(42, 20);
            this.textBox_Fixed_Value.TabIndex = 12;
            this.textBox_Fixed_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Fixed_Value_KeyPress);
            // 
            // textBox_Percentage_Value
            // 
            this.textBox_Percentage_Value.HideSelection = false;
            this.textBox_Percentage_Value.Location = new System.Drawing.Point(113, 53);
            this.textBox_Percentage_Value.Name = "textBox_Percentage_Value";
            this.textBox_Percentage_Value.Size = new System.Drawing.Size(42, 20);
            this.textBox_Percentage_Value.TabIndex = 11;
            this.textBox_Percentage_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Percentage_Value_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fixed Value";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Combobox_SKU_For_Percentage
            // 
            this.Combobox_SKU_For_Percentage.FormattingEnabled = true;
            this.Combobox_SKU_For_Percentage.Location = new System.Drawing.Point(161, 52);
            this.Combobox_SKU_For_Percentage.Name = "Combobox_SKU_For_Percentage";
            this.Combobox_SKU_For_Percentage.Size = new System.Drawing.Size(50, 21);
            this.Combobox_SKU_For_Percentage.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Percentage";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 58);
            this.button3.TabIndex = 1;
            this.button3.Text = "Create Promotion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Create_Promotion);
            // 
            // Combobox_SKU_List_For_Promotion
            // 
            this.Combobox_SKU_List_For_Promotion.FormattingEnabled = true;
            this.Combobox_SKU_List_For_Promotion.Location = new System.Drawing.Point(9, 47);
            this.Combobox_SKU_List_For_Promotion.Name = "Combobox_SKU_List_For_Promotion";
            this.Combobox_SKU_List_For_Promotion.Size = new System.Drawing.Size(86, 21);
            this.Combobox_SKU_List_For_Promotion.TabIndex = 10;
            this.Combobox_SKU_List_For_Promotion.Text = " - - -";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear Selected SKUs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Selected_SKUs_For_Promotion);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select SKU For Promotion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Select_SKU_For_Promotion);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.panel_Result);
            this.panel3.Controls.Add(this.groupBox_Selected_SKUs_For_Basket);
            this.panel3.Controls.Add(this.Combobox_SKU_List_For_Basket);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(337, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 430);
            this.panel3.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "___";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "___";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Basket Total : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Basket : ";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(114, 140);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "Clear Basket";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Clear_Basket);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "Create Basket";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CreateBasket);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Result";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 29);
            this.button7.TabIndex = 16;
            this.button7.Text = "Apply Promotions";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ApplyPromotions);
            // 
            // panel_Result
            // 
            this.panel_Result.AutoScroll = true;
            this.panel_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Result.Location = new System.Drawing.Point(9, 293);
            this.panel_Result.Name = "panel_Result";
            this.panel_Result.Size = new System.Drawing.Size(287, 125);
            this.panel_Result.TabIndex = 17;
            // 
            // groupBox_Selected_SKUs_For_Basket
            // 
            this.groupBox_Selected_SKUs_For_Basket.Location = new System.Drawing.Point(10, 85);
            this.groupBox_Selected_SKUs_For_Basket.Name = "groupBox_Selected_SKUs_For_Basket";
            this.groupBox_Selected_SKUs_For_Basket.Size = new System.Drawing.Size(188, 49);
            this.groupBox_Selected_SKUs_For_Basket.TabIndex = 15;
            this.groupBox_Selected_SKUs_For_Basket.TabStop = false;
            this.groupBox_Selected_SKUs_For_Basket.Text = "Selected SKUs For Basket";
            // 
            // Combobox_SKU_List_For_Basket
            // 
            this.Combobox_SKU_List_For_Basket.FormattingEnabled = true;
            this.Combobox_SKU_List_For_Basket.Location = new System.Drawing.Point(10, 47);
            this.Combobox_SKU_List_For_Basket.Name = "Combobox_SKU_List_For_Basket";
            this.Combobox_SKU_List_For_Basket.Size = new System.Drawing.Size(86, 21);
            this.Combobox_SKU_List_For_Basket.TabIndex = 14;
            this.Combobox_SKU_List_For_Basket.Text = " - - -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(83, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "BASKET PANEL";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 49);
            this.button5.TabIndex = 12;
            this.button5.Text = "Clear Selected SKUs";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Clear_Selected_SKUs_For_Basket);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(112, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Select SKU For Basket";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Select_SKU_For_Basket);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Promotion_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Selected_SKUs_For_Promotion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Fixed_Value;
        private System.Windows.Forms.TextBox textBox_Percentage_Value;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox Combobox_SKU_For_Percentage;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Combobox_SKU_List_For_Promotion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel_Result;
        private System.Windows.Forms.GroupBox groupBox_Selected_SKUs_For_Basket;
        private System.Windows.Forms.ComboBox Combobox_SKU_List_For_Basket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

