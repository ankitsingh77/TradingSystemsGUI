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
    public partial class BuySellStockForm : Form
    {
        private bool isSell;
        private string stockSymbol;
        private double price;
        private bool isLimit;


        public BuySellStockForm()
        {
            InitializeComponent();
        }

        public BuySellStockForm(bool isSell, string stockSymbol, double price) : this()
        {
            this.IsSell = isSell;
            this.StockSymbol = stockSymbol;
            this.Price = price;
            IsLimit = false;
        }

        public bool IsSell 
        {
            get
            {
                return isSell;
            }
            set
            {
                isSell = value;
                if (value)
                {
                    this.Text = "Sell " + StockSymbol;
                    this.btnBuySell.Text = "Sell";
                }
                else
                { 
                    this.Text = "Buy " + StockSymbol;
                    this.btnBuySell.Text = "Buy";
                }
            }
        }

        public string StockSymbol { 
            get => stockSymbol;
            set {
                    stockSymbol = value;
                    if(isSell)
                    {
                        this.Text = "Sell " + value;
                    }
                    else
                    {
                        this.Text = "Buy " + value;
                    }
            }
        }

        public double Price { get => price; 
            set { 
                    price = value; 
                    if (txtPrice.Text != price.ToString())
                    {
                        txtPrice.Text = price.ToString();
                    }
            } 
        }

        private void TxtPrice_TextChanged(object sender, System.EventArgs e)
        {
            if(Price.ToString() != txtPrice.Text)
            {
                var price = Price;
                if (double.TryParse(txtPrice.Text, out price))
                {
                    Price = price;
                }
            }
        }


        public bool IsLimit { get => isLimit;
            set {

                isLimit = value; 
                if(isLimit != rdoLimit.Checked)
                {
                    rdoLimit.Checked = isLimit;
                }
            }
        }

        private void RdoLimit_CheckedChanged(object sender, System.EventArgs e)
        {
            if(isLimit != rdoLimit.Checked)
            {
                isLimit = rdoLimit.Checked;
            }

            rdoMarket.Checked = !rdoLimit.Checked;
        }

        private void RdoMarket_CheckedChanged(object sender, System.EventArgs e)
        {
            rdoLimit.Checked = !rdoMarket.Checked;
        }

        private void BtnBuySell_Click(object sender, System.EventArgs e)
        {
            if(!isSell)
            {

            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
