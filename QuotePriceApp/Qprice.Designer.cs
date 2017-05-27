namespace ConfirmationApp
{
    partial class Qprice
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
            this.btnConfir = new System.Windows.Forms.Button();
            this.lbaunit = new System.Windows.Forms.Label();
            this.lblOrderRecord = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLimiting = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.rtbOrderRecord = new System.Windows.Forms.RichTextBox();
            this.rtbPrice = new System.Windows.Forms.RichTextBox();
            this.rtbLimiting = new System.Windows.Forms.RichTextBox();
            this.txtQuoteTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQuoteNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfir
            // 
            this.btnConfir.Location = new System.Drawing.Point(525, 522);
            this.btnConfir.Name = "btnConfir";
            this.btnConfir.Size = new System.Drawing.Size(75, 23);
            this.btnConfir.TabIndex = 0;
            this.btnConfir.Text = "生成PDF";
            this.btnConfir.UseVisualStyleBackColor = true;
            this.btnConfir.Click += new System.EventHandler(this.btnConfir_Click);
            // 
            // lbaunit
            // 
            this.lbaunit.AutoSize = true;
            this.lbaunit.Location = new System.Drawing.Point(70, 93);
            this.lbaunit.Name = "lbaunit";
            this.lbaunit.Size = new System.Drawing.Size(53, 12);
            this.lbaunit.TabIndex = 1;
            this.lbaunit.Text = "报价单位";
            // 
            // lblOrderRecord
            // 
            this.lblOrderRecord.AutoSize = true;
            this.lblOrderRecord.Location = new System.Drawing.Point(72, 189);
            this.lblOrderRecord.Name = "lblOrderRecord";
            this.lblOrderRecord.Size = new System.Drawing.Size(53, 12);
            this.lblOrderRecord.TabIndex = 2;
            this.lblOrderRecord.Text = "预定记录";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(72, 268);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "机票报价";
            // 
            // lblLimiting
            // 
            this.lblLimiting.AutoSize = true;
            this.lblLimiting.Location = new System.Drawing.Point(70, 366);
            this.lblLimiting.Name = "lblLimiting";
            this.lblLimiting.Size = new System.Drawing.Size(53, 12);
            this.lblLimiting.TabIndex = 4;
            this.lblLimiting.Text = "限制条件";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(175, 93);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.ReadOnly = true;
            this.txtUnits.Size = new System.Drawing.Size(236, 21);
            this.txtUnits.TabIndex = 5;
            this.txtUnits.Text = "abc有限公司";
            // 
            // rtbOrderRecord
            // 
            this.rtbOrderRecord.Location = new System.Drawing.Point(175, 142);
            this.rtbOrderRecord.Name = "rtbOrderRecord";
            this.rtbOrderRecord.Size = new System.Drawing.Size(262, 99);
            this.rtbOrderRecord.TabIndex = 7;
            this.rtbOrderRecord.Text = "";
            // 
            // rtbPrice
            // 
            this.rtbPrice.Location = new System.Drawing.Point(175, 247);
            this.rtbPrice.Name = "rtbPrice";
            this.rtbPrice.Size = new System.Drawing.Size(262, 87);
            this.rtbPrice.TabIndex = 8;
            this.rtbPrice.Text = " ";
            // 
            // rtbLimiting
            // 
            this.rtbLimiting.Location = new System.Drawing.Point(175, 354);
            this.rtbLimiting.Name = "rtbLimiting";
            this.rtbLimiting.Size = new System.Drawing.Size(253, 52);
            this.rtbLimiting.TabIndex = 9;
            this.rtbLimiting.Text = "";
            // 
            // txtQuoteTel
            // 
            this.txtQuoteTel.Location = new System.Drawing.Point(175, 500);
            this.txtQuoteTel.Name = "txtQuoteTel";
            this.txtQuoteTel.ReadOnly = true;
            this.txtQuoteTel.Size = new System.Drawing.Size(100, 21);
            this.txtQuoteTel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "报价人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "报价人电话";
            // 
            // cmbQuoteNames
            // 
            this.cmbQuoteNames.FormattingEnabled = true;
            this.cmbQuoteNames.Location = new System.Drawing.Point(175, 444);
            this.cmbQuoteNames.Name = "cmbQuoteNames";
            this.cmbQuoteNames.Size = new System.Drawing.Size(121, 20);
            this.cmbQuoteNames.TabIndex = 14;
            this.cmbQuoteNames.SelectedValueChanged += new System.EventHandler(this.cmbQuoteNames_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "客户名称";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(175, 47);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(253, 21);
            this.txtCustomerName.TabIndex = 16;
            // 
            // Qprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 588);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbQuoteNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuoteTel);
            this.Controls.Add(this.rtbLimiting);
            this.Controls.Add(this.rtbPrice);
            this.Controls.Add(this.rtbOrderRecord);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblLimiting);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblOrderRecord);
            this.Controls.Add(this.lbaunit);
            this.Controls.Add(this.btnConfir);
            this.Name = "Qprice";
            this.Text = "报价单v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfir;
        private System.Windows.Forms.Label lbaunit;
        private System.Windows.Forms.Label lblOrderRecord;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLimiting;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.RichTextBox rtbOrderRecord;
        private System.Windows.Forms.RichTextBox rtbPrice;
        private System.Windows.Forms.RichTextBox rtbLimiting;
        private System.Windows.Forms.TextBox txtQuoteTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQuoteNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}

