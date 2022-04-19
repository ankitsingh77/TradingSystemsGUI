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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, System.EventArgs e)
        {
            this.txtUserName.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            //this.pnlLogin.Visible = false;
            //this.pnlLogin.Enabled = false;
            this.pnlSignUp.Visible = true;
            this.pnlSignUp.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.pnlSignUp.Visible = false;
            this.pnlLogin.Visible = true;
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            TradingServiceClient client = new TradingServiceClient();
            var userId = client.CreateUser(new TradingSystemServer.User()
            {
                UserName = txtUserNameSignUp.Text,
                EmailId = txtEmailId.Text,
                FullName = txtFullName.Text,
                Type = cmbUserType.SelectedIndex,
                Password = txtPwdSignUp.Text
            });

            if(userId != Guid.Empty)
            {
                MessageBox.Show("Account Created");
            }

            ClearSignUp();
            this.pnlSignUp.Visible = false;
            this.pnlLogin.Visible = true;
        }

        private void ClearSignUp()
        {
            txtUserNameSignUp.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmailId.Text = string.Empty;
            cmbUserType.SelectedIndex = 0;
            txtPwdSignUp.Text = string.Empty;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("UserName or Password cannot be empty");
                return;
            }

            TradingSystemServer.User user = null;

            try
            {
                TradingServiceClient client = new TradingServiceClient();
                user = client.ValidateUser(txtUserName.Text, txtPassword.Text);
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                MessageBox.Show("Unable to connect to the server");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try later");
                return;
            }

            if(user == null)
            {
                MessageBox.Show("Username or password is incorrect");
            }
            else if(user.Type == 1)
            {
                using (var mainForm = new MainForm(user))
                {
                    UserContext.SetUserContext(user);
                    mainForm.ShowDialog();
                }
            }
            else
            {
                using(var adminForm = new AdminForm(user))
                {
                    UserContext.SetUserContext(user);
                    adminForm.ShowDialog();
                }
            }

        }

    }
}
