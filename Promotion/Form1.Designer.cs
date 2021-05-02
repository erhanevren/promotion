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
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // 
            // textBox_Percentage_Value
            // 
            this.textBox_Percentage_Value.HideSelection = false;
            this.textBox_Percentage_Value.Location = new System.Drawing.Point(113, 53);
            this.textBox_Percentage_Value.Name = "textBox_Percentage_Value";
            this.textBox_Percentage_Value.Size = new System.Drawing.Size(42, 20);
            this.textBox_Percentage_Value.TabIndex = 11;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

