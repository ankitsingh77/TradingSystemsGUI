
namespace TradingSystemsGUI
{
    partial class BuySellStockForm
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
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rdoMarket = new System.Windows.Forms.RadioButton();
            this.rdoLimit = new System.Windows.Forms.RadioButton();
            this.btnBuySell = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(58, 68);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(33, 20);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Qty";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(128, 65);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(111, 26);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtPrice

            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 134);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 26);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += TxtPrice_TextChanged;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(58, 137);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // rdoMarket
            // 
            this.rdoMarket.AutoSize = true;
            this.rdoMarket.Location = new System.Drawing.Point(62, 208);
            this.rdoMarket.Name = "rdoMarket";
            this.rdoMarket.Size = new System.Drawing.Size(83, 24);
            this.rdoMarket.TabIndex = 4;
            this.rdoMarket.TabStop = true;
            this.rdoMarket.Text = "Market";
            this.rdoMarket.UseVisualStyleBackColor = true;
            this.rdoMarket.CheckedChanged += RdoMarket_CheckedChanged;
            // 
            // rdoLimit
            // 
            this.rdoLimit.AutoSize = true;
            this.rdoLimit.Location = new System.Drawing.Point(62, 238);
            this.rdoLimit.Name = "rdoLimit";
            this.rdoLimit.Size = new System.Drawing.Size(67, 24);
            this.rdoLimit.TabIndex = 5;
            this.rdoLimit.TabStop = true;
            this.rdoLimit.Text = "Limit";
            this.rdoLimit.UseVisualStyleBackColor = true;
            this.rdoLimit.CheckedChanged += RdoLimit_CheckedChanged;
            // 
            // btnBuySell
            // 
            this.btnBuySell.Location = new System.Drawing.Point(164, 287);
            this.btnBuySell.Name = "btnBuySell";
            this.btnBuySell.Size = new System.Drawing.Size(93, 38);
            this.btnBuySell.TabIndex = 6;
            this.btnBuySell.Text = "Buy";
            this.btnBuySell.UseVisualStyleBackColor = true;
            this.btnBuySell.Click += BtnBuySell_Click;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += BtnCancel_Click;
            // 
            // BuySellStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 372);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBuySell);
            this.Controls.Add(this.rdoLimit);
            this.Controls.Add(this.rdoMarket);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuySellStockForm";
            this.Text = "Buy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton rdoMarket;
        private System.Windows.Forms.RadioButton rdoLimit;
        private System.Windows.Forms.Button btnBuySell;
        private System.Windows.Forms.Button btnCancel;
    }
}