using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;

namespace Vault
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Try to initiate connection
            if (tbox_Username.Text == "" || tbox_Password.Text == "") return;

            // Save database credentials to Database class
            Database.Username = tbox_Username.Text;
            Database.Password = tbox_Password.Text;

            // Estabilish connection
            if (!Database.IsValid) Database.TryConnect();

            // Check if connection is valid, if yes, update exchange rates
            if (Database.IsValid && Database.Connection.State == ConnectionState.Open)
            {

                txt_ConnectionStatus.Visible = true;
                txt_ConnectionStatus.Text = "Successfully connected.";

                // Update Currencies
                Database.Currencies_UpdateDatabase();

                new Exchange().Show();
                new TransactionsLog().Show();
                Hide();
            }
            else
            {
                txt_ConnectionStatus.Visible = true;
                txt_ConnectionStatus.Text = "Connection Failed.";
            }

        }

    }
}
