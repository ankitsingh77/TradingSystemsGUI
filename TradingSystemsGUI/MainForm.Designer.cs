
namespace TradingSystemsGUI
{
    partial class MainForm
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
            this.pnlUserDetails = new System.Windows.Forms.Panel();
            this.pnlBalances = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.flPanelStockTickers = new System.Windows.Forms.FlowLayoutPanel();
            this.flPanelStockHoldings = new System.Windows.Forms.FlowLayoutPanel();
            this.flPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.Controls.Add(this.lblUserName);
            this.pnlUserDetails.Location = new System.Drawing.Point(0, 2);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.Size = new System.Drawing.Size(450, 58);
            this.pnlUserDetails.TabIndex = 2;
            // 
            // pnlBalances
            // 
            this.pnlBalances.Location = new System.Drawing.Point(453, 739);
            this.pnlBalances.Name = "pnlBalances";
            this.pnlBalances.Size = new System.Drawing.Size(1447, 277);
            this.pnlBalances.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(77, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(129, 29);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // flPanelStockTickers
            // 
            this.flPanelStockTickers.AutoScroll = true;
            this.flPanelStockTickers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelStockTickers.Location = new System.Drawing.Point(4, 64);
            this.flPanelStockTickers.Name = "flPanelStockTickers";
            this.flPanelStockTickers.Size = new System.Drawing.Size(446, 951);
            this.flPanelStockTickers.TabIndex = 0;
            // 
            // flPanelStockHoldings
            // 
            this.flPanelStockHoldings.AutoScroll = true;
            this.flPanelStockHoldings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelStockHoldings.Location = new System.Drawing.Point(453, 2);
            this.flPanelStockHoldings.Name = "flPanelStockHoldings";
            this.flPanelStockHoldings.Size = new System.Drawing.Size(1447, 392);
            this.flPanelStockHoldings.TabIndex = 6;
            // 
            // flPanelOrders
            // 
            this.flPanelOrders.AutoScroll = true;
            this.flPanelOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelOrders.Location = new System.Drawing.Point(456, 400);
            this.flPanelOrders.Name = "flPanelOrders";
            this.flPanelOrders.Size = new System.Drawing.Size(1441, 332);
            this.flPanelOrders.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1017);
            this.Controls.Add(this.flPanelOrders);
            this.Controls.Add(this.flPanelStockHoldings);
            this.Controls.Add(this.flPanelStockTickers);
            this.Controls.Add(this.pnlBalances);
            this.Controls.Add(this.pnlUserDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Dashboard";
            this.pnlUserDetails.ResumeLayout(false);
            this.pnlUserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUserDetails;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlBalances;
        private System.Windows.Forms.FlowLayoutPanel flPanelStockTickers;
        private System.Windows.Forms.FlowLayoutPanel flPanelStockHoldings;
        private System.Windows.Forms.FlowLayoutPanel flPanelOrders;
    }
}