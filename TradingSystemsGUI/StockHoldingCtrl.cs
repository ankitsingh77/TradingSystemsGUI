using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingSystemsGUI
{
    public partial class StockHoldingCtrl : UserControl
    {

        private string stockSymbol;
        private int qty;
        private double price;

        public StockHoldingCtrl()
        {
            InitializeComponent();
        }

        public StockHoldingCtrl(string stockSymbol, int qty, double price) : this()
        {
            StockSymbol = stockSymbol;
            Qty = qty;
            Price = price;
        }

        public string StockSymbol { get => stockSymbol;
            set 
            { 
                stockSymbol = value;
                this.lblStockSymbol.Text = value;
            }
        }

        public int Qty { get => qty;
            set
            {
                qty = value;
                this.lblQty.Text = value.ToString();
                this.lblValue.Text = (price * (double)qty).ToString();
            }
        }
        public double Price { get => price;
            set 
            {
                price = value;
                this.lblPrice.Text = price.ToString();
                this.lblValue.Text = (price * (double)qty).ToString();
            }
        }
    }
}
