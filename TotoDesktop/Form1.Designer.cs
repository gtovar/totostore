namespace TotoDesktop
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
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtDescriptionProduct = new System.Windows.Forms.TextBox();
            this.chkDemand = new System.Windows.Forms.CheckBox();
            this.cmbProducts2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(376, 29);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(120, 21);
            this.cmbProducts.TabIndex = 0;
            this.cmbProducts.DataSourceChanged += new System.EventHandler(this.cmbProducts_DataSourceChanged);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(376, 62);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(120, 20);
            this.txtTest.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numBox
            // 
            this.numBox.DecimalPlaces = 2;
            this.numBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numBox.Location = new System.Drawing.Point(192, 30);
            this.numBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(173, 20);
            this.numBox.TabIndex = 3;
            this.numBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Location = new System.Drawing.Point(9, 14);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(35, 13);
            this.lblNameProduct.TabIndex = 8;
            this.lblNameProduct.Text = "Name";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(12, 30);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(173, 20);
            this.txtNameProduct.TabIndex = 9;
            // 
            // txtDescriptionProduct
            // 
            this.txtDescriptionProduct.Location = new System.Drawing.Point(12, 81);
            this.txtDescriptionProduct.Multiline = true;
            this.txtDescriptionProduct.Name = "txtDescriptionProduct";
            this.txtDescriptionProduct.Size = new System.Drawing.Size(353, 78);
            this.txtDescriptionProduct.TabIndex = 10;
            // 
            // chkDemand
            // 
            this.chkDemand.AutoSize = true;
            this.chkDemand.Location = new System.Drawing.Point(12, 179);
            this.chkDemand.Name = "chkDemand";
            this.chkDemand.Size = new System.Drawing.Size(66, 17);
            this.chkDemand.TabIndex = 11;
            this.chkDemand.Text = "Demand";
            this.chkDemand.UseVisualStyleBackColor = true;
            // 
            // cmbProducts2
            // 
            this.cmbProducts2.FormattingEnabled = true;
            this.cmbProducts2.Location = new System.Drawing.Point(376, 138);
            this.cmbProducts2.Name = "cmbProducts2";
            this.cmbProducts2.Size = new System.Drawing.Size(120, 21);
            this.cmbProducts2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 262);
            this.Controls.Add(this.cmbProducts2);
            this.Controls.Add(this.chkDemand);
            this.Controls.Add(this.txtDescriptionProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.cmbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtDescriptionProduct;
        private System.Windows.Forms.CheckBox chkDemand;
        private System.Windows.Forms.ComboBox cmbProducts2;
    }
}

