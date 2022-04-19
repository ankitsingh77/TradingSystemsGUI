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
    public partial class MainForm : Form
    {
        private readonly User user;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User user) : this()
        {
            this.user = user;
            lblUserName.Text = user.FullName;
            LoadStocks();
            AddHoldings();
        }

        private void LoadStocks()
        {
            var client = new TradingServiceClient();
            var stocks = client.GetAllStocks();
            foreach (var stock in stocks)
            {
                var stockTickerCtrl = new StockTickerCtrl(stock.StockId, stock.StockSymbol, stock.Price, "USD");
                stockTickerCtrl.OnRefresh += Refresh;
                flPanelStockTickers.Controls.Add(stockTickerCtrl);
            }
        }

        private void AddHoldings()
        {
            var client = new TradingServiceClient();
            var portFolio = client.GetPortFolio(user.Id);
            lblBalance.Text = portFolio.Balance.ToString();
            flPanelStockHoldings.Controls.Clear();
            foreach(var stock in portFolio.Stocks)
            {
                if (stock.Quantity != 0)
                {
                    var holdinCtrl = new StockHoldingCtrl(stock.StockSymbol, stock.Quantity, stock.Price);
                    flPanelStockHoldings.Controls.Add(holdinCtrl);
                }
            }
        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            var client = new TradingServiceClient();
            double amountToAdd = 0;
            if (!double.TryParse(txtAddBalance.Text, out amountToAdd))
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            var balance = client.AddBalance(user.Id, amountToAdd);
            lblBalance.Text = balance.ToString();
            txtAddBalance.Text = "0";
        }

        private void Refresh()
        {
            AddHoldings();
        }
    }
}
