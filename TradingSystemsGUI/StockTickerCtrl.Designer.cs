
namespace TradingSystemsGUI
{
    partial class StockTickerCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockSymbol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.lblStockPrice);
            this.panel1.Controls.Add(this.lblStockSymbol);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnSell
            // 
            this.btnSell.ForeColor = System.Drawing.Color.Red;
            this.btnSell.Location = new System.Drawing.Point(256, 11);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(26, 23);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "S";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += BtnSell_Click;
            // 
            // btnBuy
            // 
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuy.Location = new System.Drawing.Point(226, 11);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(26, 23);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "B";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += BtnBuy_Click;
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(150, 17);
            this.lblStockPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(60, 13);
            this.lblStockPrice.TabIndex = 1;
            this.lblStockPrice.Text = "100000 $";
            // 
            // lblStockSymbol
            // 
            this.lblStockSymbol.AutoSize = true;
            this.lblStockSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSymbol.Location = new System.Drawing.Point(18, 16);
            this.lblStockSymbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockSymbol.Name = "lblStockSymbol";
            this.lblStockSymbol.Size = new System.Drawing.Size(47, 13);
            this.lblStockSymbol.TabIndex = 0;
            this.lblStockSymbol.Text = "Symbol";
            // 
            // StockTickerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockTickerCtrl";
            this.Size = new System.Drawing.Size(291, 45);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblStockSymbol;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
    }
}
