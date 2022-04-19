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
    public partial class StockTickerCtrl : UserControl
    {

        private string stockSymbol;
        private double stockPrice;
        private string currencyCode;
        private Guid stockId;
        public event Action OnRefresh;

        public StockTickerCtrl()
        {
            InitializeComponent();
        }

        public StockTickerCtrl(Guid stockId, string symbol, double price, string currencyCode) : this()
        {
            this.stockId = stockId;
            this.StockSymbol = symbol;
            this.StockPrice = price;
            this.CurrencyCode = currencyCode;
        }

        public string StockSymbol { get => stockSymbol; set { stockSymbol = value; this.lblStockSymbol.Text = value; } }
        public double StockPrice { get => stockPrice; set  { stockPrice = value; this.lblStockPrice.Text = value + " " + CurrencyCode; } }
        public string CurrencyCode { get => currencyCode; set  { currencyCode = value; this.lblStockPrice.Text = StockPrice + " " + value; } }

        private void BtnSell_Click(object sender, System.EventArgs e)
        {
            using(var buySellForm = new BuySellStockForm(true, StockSymbol, StockPrice, stockId))
            {
                buySellForm.ShowDialog();
                if (OnRefresh != null)
                {
                    OnRefresh();
                }
            }
        }

        private void BtnBuy_Click(object sender, System.EventArgs e)
        {
            using (var buySellForm = new BuySellStockForm(false, StockSymbol, StockPrice, stockId))
            {
                buySellForm.ShowDialog();
                if (OnRefresh != null)
                {
                    OnRefresh();
                }
            }
        }
    }
}
