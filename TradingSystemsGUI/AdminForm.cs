using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingSystemServer;

namespace TradingSystemsGUI
{
    public partial class AdminForm : Form
    {
        private readonly User user;

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(User user) : this()
        {
            this.user = user;
        }

        private void createStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlCreateStock.Visible = true;
            this.pnlChangeSchedule.Visible = false;
            this.pnlChangeHours.Visible = false;
        }

        private void changeMarketHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlCreateStock.Visible = false;
            this.pnlChangeSchedule.Visible = false;
            this.pnlChangeHours.Visible = true;
        }

        private void changeMarketScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlCreateStock.Visible = false;
            this.pnlChangeSchedule.Visible = true;
            this.pnlChangeHours.Visible = false;
        }

        private void BtnCreateStock_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
