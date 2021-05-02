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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Selected_SKUs_For_Promotion = new System.Windows.Forms.GroupBox();
            this.Combobox_SKU_List_For_Promotion = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "PROMOTION PANEL";
            // 
            // groupBox_Selected_SKUs_For_Promotion
            // 
            this.groupBox_Selected_SKUs_For_Promotion.Location = new System.Drawing.Point(28, 102);
            this.groupBox_Selected_SKUs_For_Promotion.Name = "groupBox_Selected_SKUs_For_Promotion";
            this.groupBox_Selected_SKUs_For_Promotion.Size = new System.Drawing.Size(189, 49);
            this.groupBox_Selected_SKUs_For_Promotion.TabIndex = 17;
            this.groupBox_Selected_SKUs_For_Promotion.TabStop = false;
            this.groupBox_Selected_SKUs_For_Promotion.Text = "Selected SKUs For Promotion";
            // 
            // Combobox_SKU_List_For_Promotion
            // 
            this.Combobox_SKU_List_For_Promotion.FormattingEnabled = true;
            this.Combobox_SKU_List_For_Promotion.Location = new System.Drawing.Point(28, 64);
            this.Combobox_SKU_List_For_Promotion.Name = "Combobox_SKU_List_For_Promotion";
            this.Combobox_SKU_List_For_Promotion.Size = new System.Drawing.Size(86, 21);
            this.Combobox_SKU_List_For_Promotion.TabIndex = 16;
            this.Combobox_SKU_List_For_Promotion.Text = " - - -";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear Selected SKUs";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Select SKU For Promotion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Selected_SKUs_For_Promotion);
            this.Controls.Add(this.Combobox_SKU_List_For_Promotion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Selected_SKUs_For_Promotion;
        private System.Windows.Forms.ComboBox Combobox_SKU_List_For_Promotion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

