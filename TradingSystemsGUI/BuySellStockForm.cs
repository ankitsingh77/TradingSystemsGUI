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
        private Guid stockId;


        public BuySellStockForm()
        {
            InitializeComponent();
        }

        public BuySellStockForm(bool isSell, string stockSymbol, double price, Guid stockId) : this()
        {
            this.IsSell = isSell;
            this.StockSymbol = stockSymbol;
            this.Price = price;
            IsLimit = false;
            this.stockId = stockId;
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
            var user = UserContext.GetUserContext();
            var client = new TradingServiceClient();
            var portfolio = client.GetPortFolio(user.Id);
            var stock = client.GetAllStocks().Where(o => o.StockId == stockId).FirstOrDefault();
            var portfolioStock = portfolio.Stocks.Where(o => o.StockId == stockId).FirstOrDefault();
            if (!isSell)
            {
                if (stock != null)
                {
                    double quantity = 0;
                    if(double.TryParse(txtQuantity.Text, out quantity))
                    {
                        if(portfolio.Balance >= (quantity * stock.Price))
                        {
                            if(client.PurchaseStock(this.stockId, user.Id, (int)quantity))
                            {
                                MessageBox.Show("Buy transaction succesfull");
                                this.Close();
                                return;
                            }
                        }
                    }

                }

                MessageBox.Show("Unable to complete transaction");
            }
            else
            {
                if(portfolioStock != null)
                {
                    double quantity = 0;
                    if (double.TryParse(txtQuantity.Text, out quantity))
                    {
                        if (portfolioStock.Quantity >= quantity)
                        {
                            if (client.SellStock(portfolioStock.StockId, user.Id, (int)quantity))
                            {
                                MessageBox.Show("Sell transaction succesfull");
                                this.Close();
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Unable to complete transaction");
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
