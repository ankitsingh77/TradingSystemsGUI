
namespace TradingSystemsGUI
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createStock = new System.Windows.Forms.ToolStripMenuItem();
            this.createStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMarketHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMarketScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCreateStock = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSotckName = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnCreateStock = new System.Windows.Forms.Button();
            this.pnlChangeHours = new System.Windows.Forms.Panel();
            this.pnlChangeSchedule = new System.Windows.Forms.Panel();
            this.lblScheduleHeader = new System.Windows.Forms.Label();
            this.lblMarketHours = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlCreateStock.SuspendLayout();
            this.pnlChangeSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStock});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createStock
            // 
            this.createStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStockToolStripMenuItem,
            this.changeMarketHoursToolStripMenuItem,
            this.changeMarketScheduleToolStripMenuItem});
            this.createStock.Name = "createStock";
            this.createStock.ShowShortcutKeys = false;
            this.createStock.Size = new System.Drawing.Size(41, 20);
            this.createStock.Text = "Task";
            // 
            // createStockToolStripMenuItem
            // 
            this.createStockToolStripMenuItem.Name = "createStockToolStripMenuItem";
            this.createStockToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.createStockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.createStockToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.createStockToolStripMenuItem.Text = "Create Stock";
            this.createStockToolStripMenuItem.Click += new System.EventHandler(this.createStockToolStripMenuItem_Click);
            // 
            // changeMarketHoursToolStripMenuItem
            // 
            this.changeMarketHoursToolStripMenuItem.Name = "changeMarketHoursToolStripMenuItem";
            this.changeMarketHoursToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.changeMarketHoursToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.changeMarketHoursToolStripMenuItem.Text = "Change Market Hours";
            this.changeMarketHoursToolStripMenuItem.Click += new System.EventHandler(this.changeMarketHoursToolStripMenuItem_Click);
            // 
            // changeMarketScheduleToolStripMenuItem
            // 
            this.changeMarketScheduleToolStripMenuItem.Name = "changeMarketScheduleToolStripMenuItem";
            this.changeMarketScheduleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.changeMarketScheduleToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.changeMarketScheduleToolStripMenuItem.Text = "Change Market Schedule";
            this.changeMarketScheduleToolStripMenuItem.Click += new System.EventHandler(this.changeMarketScheduleToolStripMenuItem_Click);
            // 
            // pnlCreateStock
            // 
            this.pnlCreateStock.Controls.Add(this.btnCreateStock);
            this.pnlCreateStock.Controls.Add(this.txtVolume);
            this.pnlCreateStock.Controls.Add(this.txtPrice);
            this.pnlCreateStock.Controls.Add(this.txtSymbol);
            this.pnlCreateStock.Controls.Add(this.lblVolume);
            this.pnlCreateStock.Controls.Add(this.lblPrice);
            this.pnlCreateStock.Controls.Add(this.lblSymbol);
            this.pnlCreateStock.Controls.Add(this.lblHeader);
            this.pnlCreateStock.Controls.Add(this.txtSotckName);
            this.pnlCreateStock.Controls.Add(this.lblName);
            this.pnlCreateStock.Location = new System.Drawing.Point(0, 39);
            this.pnlCreateStock.Name = "pnlCreateStock";
            this.pnlCreateStock.Size = new System.Drawing.Size(494, 423);
            this.pnlCreateStock.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(119, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtSotckName
            // 
            this.txtSotckName.Location = new System.Drawing.Point(216, 80);
            this.txtSotckName.Name = "txtSotckName";
            this.txtSotckName.Size = new System.Drawing.Size(134, 20);
            this.txtSotckName.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(172, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(78, 29);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Stock";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(119, 123);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblSymbol.TabIndex = 3;
            this.lblSymbol.Text = "Symbol";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(119, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(119, 198);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volume";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(216, 120);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(134, 20);
            this.txtSymbol.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(216, 160);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(216, 198);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(134, 20);
            this.txtVolume.TabIndex = 9;
            // 
            // btnCreateStock
            // 
            this.btnCreateStock.Location = new System.Drawing.Point(192, 270);
            this.btnCreateStock.Name = "btnCreateStock";
            this.btnCreateStock.Size = new System.Drawing.Size(75, 23);
            this.btnCreateStock.TabIndex = 10;
            this.btnCreateStock.Text = "Create";
            this.btnCreateStock.UseVisualStyleBackColor = true;
            this.btnCreateStock.Click += BtnCreateStock_Click;
            // 
            // pnlChangeHours
            // 
            this.pnlChangeHours.Controls.Add(this.lblMarketHours);
            this.pnlChangeHours.Location = new System.Drawing.Point(0, 39);
            this.pnlChangeHours.Name = "pnlChangeHours";
            this.pnlChangeHours.Size = new System.Drawing.Size(491, 423);
            this.pnlChangeHours.TabIndex = 2;
            // 
            // pnlChangeSchedule
            // 
            this.pnlChangeSchedule.Controls.Add(this.lblScheduleHeader);
            this.pnlChangeSchedule.Location = new System.Drawing.Point(0, 39);
            this.pnlChangeSchedule.Name = "pnlChangeSchedule";
            this.pnlChangeSchedule.Size = new System.Drawing.Size(491, 417);
            this.pnlChangeSchedule.TabIndex = 3;
            // 
            // lblScheduleHeader
            // 
            this.lblScheduleHeader.AutoSize = true;
            this.lblScheduleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleHeader.Location = new System.Drawing.Point(157, 53);
            this.lblScheduleHeader.Name = "lblScheduleHeader";
            this.lblScheduleHeader.Size = new System.Drawing.Size(110, 25);
            this.lblScheduleHeader.TabIndex = 0;
            this.lblScheduleHeader.Text = "Schedule";
            // 
            // lblMarketHours
            // 
            this.lblMarketHours.AutoSize = true;
            this.lblMarketHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketHours.Location = new System.Drawing.Point(157, 52);
            this.lblMarketHours.Name = "lblMarketHours";
            this.lblMarketHours.Size = new System.Drawing.Size(153, 25);
            this.lblMarketHours.TabIndex = 0;
            this.lblMarketHours.Text = "Market Hours";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(494, 507);
            this.Controls.Add(this.pnlChangeSchedule);
            this.Controls.Add(this.pnlChangeHours);
            this.Controls.Add(this.pnlCreateStock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.pnlChangeHours.Visible = false;
            this.pnlChangeSchedule.Visible = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlChangeSchedule.ResumeLayout(false);
            this.pnlChangeSchedule.PerformLayout();
            this.pnlCreateStock.ResumeLayout(false);
            this.pnlCreateStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createStock;
        private System.Windows.Forms.ToolStripMenuItem createStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMarketHoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMarketScheduleToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCreateStock;
        private System.Windows.Forms.Button btnCreateStock;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSotckName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlChangeHours;
        private System.Windows.Forms.Panel pnlChangeSchedule;
        private System.Windows.Forms.Label lblScheduleHeader;
        private System.Windows.Forms.Label lblMarketHours;
    }
}