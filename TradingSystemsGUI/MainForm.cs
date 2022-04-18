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
        }

        private void LoadStocks()
        {
            var client = new TradingServiceClient();
            var stocks = client.GetAllStocks();
            foreach (var stock in stocks)
            {
                var stockTickerCtrl = new StockTickerCtrl(stock.StockId, stock.StockSymbol, stock.Price, "USD");
                flPanelStockTickers.Controls.Add(stockTickerCtrl);
            }
        }

        private void AddTickers(Guid userId)
        {
            var client = new TradingServiceClient();
            var portFolio = client.GetPortFolio(userId);
            foreach(var stock in portFolio.Stocks)
            {
                var holdinCtrl = new StockHoldingCtrl(stock.StockSymbol, stock.Volume, stock.Price);
                flPanelStockHoldings.Controls.Add(holdinCtrl);
            }
        }
    }
}
