
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlBalances = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.lblAmountToAdd = new System.Windows.Forms.Label();
            this.txtAddBalance = new System.Windows.Forms.TextBox();
            this.flPanelStockTickers = new System.Windows.Forms.FlowLayoutPanel();
            this.flPanelStockHoldings = new System.Windows.Forms.FlowLayoutPanel();
            this.flPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserDetails.SuspendLayout();
            this.pnlBalances.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserDetails.Controls.Add(this.lblUserName);
            this.pnlUserDetails.Location = new System.Drawing.Point(0, 2);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.Size = new System.Drawing.Size(482, 57);
            this.pnlUserDetails.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(76, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(129, 29);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // pnlBalances
            // 
            this.pnlBalances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBalances.Controls.Add(this.lblBalance);
            this.pnlBalances.Controls.Add(this.lblBalanceTitle);
            this.pnlBalances.Controls.Add(this.btnAddBalance);
            this.pnlBalances.Controls.Add(this.lblAmountToAdd);
            this.pnlBalances.Controls.Add(this.txtAddBalance);
            this.pnlBalances.Location = new System.Drawing.Point(489, 738);
            this.pnlBalances.Name = "pnlBalances";
            this.pnlBalances.Size = new System.Drawing.Size(1410, 276);
            this.pnlBalances.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(227, 110);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 29);
            this.lblBalance.TabIndex = 4;
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTitle.Location = new System.Drawing.Point(18, 108);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(161, 29);
            this.lblBalanceTitle.TabIndex = 3;
            this.lblBalanceTitle.Text = "Cash Balance";
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBalance.Location = new System.Drawing.Point(440, 19);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(144, 48);
            this.btnAddBalance.TabIndex = 2;
            this.btnAddBalance.Text = "Add";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            this.btnAddBalance.Click += new System.EventHandler(this.btnAddBalance_Click);
            // 
            // lblAmountToAdd
            // 
            this.lblAmountToAdd.AutoSize = true;
            this.lblAmountToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToAdd.Location = new System.Drawing.Point(18, 30);
            this.lblAmountToAdd.Name = "lblAmountToAdd";
            this.lblAmountToAdd.Size = new System.Drawing.Size(169, 29);
            this.lblAmountToAdd.TabIndex = 1;
            this.lblAmountToAdd.Text = "Amount to Add";
            // 
            // txtAddBalance
            // 
            this.txtAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBalance.Location = new System.Drawing.Point(224, 26);
            this.txtAddBalance.Name = "txtAddBalance";
            this.txtAddBalance.Size = new System.Drawing.Size(186, 35);
            this.txtAddBalance.TabIndex = 0;
            // 
            // flPanelStockTickers
            // 
            this.flPanelStockTickers.AutoScroll = true;
            this.flPanelStockTickers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPanelStockTickers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelStockTickers.Location = new System.Drawing.Point(4, 65);
            this.flPanelStockTickers.Name = "flPanelStockTickers";
            this.flPanelStockTickers.Size = new System.Drawing.Size(478, 950);
            this.flPanelStockTickers.TabIndex = 0;
            this.flPanelStockTickers.WrapContents = false;
            // 
            // flPanelStockHoldings
            // 
            this.flPanelStockHoldings.AutoScroll = true;
            this.flPanelStockHoldings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPanelStockHoldings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelStockHoldings.Location = new System.Drawing.Point(489, 2);
            this.flPanelStockHoldings.Name = "flPanelStockHoldings";
            this.flPanelStockHoldings.Size = new System.Drawing.Size(1410, 391);
            this.flPanelStockHoldings.TabIndex = 6;
            // 
            // flPanelOrders
            // 
            this.flPanelOrders.AutoScroll = true;
            this.flPanelOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPanelOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelOrders.Location = new System.Drawing.Point(489, 400);
            this.flPanelOrders.Name = "flPanelOrders";
            this.flPanelOrders.Size = new System.Drawing.Size(1408, 331);
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
            this.FormClosed += MainForm_FormClosed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Dashboard";
            this.pnlUserDetails.ResumeLayout(false);
            this.pnlUserDetails.PerformLayout();
            this.pnlBalances.ResumeLayout(false);
            this.pnlBalances.PerformLayout();
            this.ResumeLayout(false);

        }

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            UserContext.ClearUserContext();
        }

        #endregion
        private System.Windows.Forms.Panel pnlUserDetails;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlBalances;
        private System.Windows.Forms.FlowLayoutPanel flPanelStockTickers;
        private System.Windows.Forms.FlowLayoutPanel flPanelStockHoldings;
        private System.Windows.Forms.FlowLayoutPanel flPanelOrders;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceTitle;
        private System.Windows.Forms.Button btnAddBalance;
        private System.Windows.Forms.Label lblAmountToAdd;
        private System.Windows.Forms.TextBox txtAddBalance;
    }
}