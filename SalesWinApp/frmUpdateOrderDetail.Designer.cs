﻿
namespace SalesWinApp
{
    partial class frmUpdateOrderDetail
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtUniPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(253, 127);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(220, 27);
            this.txtOrderID.TabIndex = 0;
            // 
            // txtUniPrice
            // 
            this.txtUniPrice.Location = new System.Drawing.Point(253, 259);
            this.txtUniPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUniPrice.Name = "txtUniPrice";
            this.txtUniPrice.ReadOnly = true;
            this.txtUniPrice.Size = new System.Drawing.Size(220, 27);
            this.txtUniPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(253, 323);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(220, 27);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(253, 391);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(220, 27);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(103, 131);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 5;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(103, 197);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(95, 20);
            this.lbProductName.TabIndex = 6;
            this.lbProductName.Text = "Prduct Name";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(103, 263);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 7;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(103, 327);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(103, 391);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 20);
            this.lbDiscount.TabIndex = 9;
            this.lbDiscount.Text = "Discount";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(253, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(253, 195);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(220, 28);
            this.cbProductName.TabIndex = 13;
            this.cbProductName.SelectedIndexChanged += new System.EventHandler(this.cbProductName_SelectedIndexChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(253, 391);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(11, 27);
            this.txtProductID.TabIndex = 14;
            // 
            // frmUpdateOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 625);
            this.Controls.Add(this.cbProductName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUniPrice);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtProductID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUpdateOrderDetail";
            this.Text = "frmUpdateOrderDetail";
            this.Load += new System.EventHandler(this.frmUpdateOrderDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtUniPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.TextBox txtProductID;
    }
}