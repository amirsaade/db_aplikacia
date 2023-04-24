using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vault
{
    public partial class TransactionsLog : Form
    {
        public TransactionsLog()
        {
            InitializeComponent();
        }

        private bool GetTransactionLogs(string customerID)
        {
            if (!Database.IsValid) return false;
           
            MySqlCommand cmd;

            // Check if customer exists
            cmd = new MySqlCommand("SELECT COUNT(*) FROM Customers WHERE passport_number = @passportNumber", Database.Connection);
            cmd.Parameters.AddWithValue("@passportNumber", customerID);
            if (Convert.ToUInt32(cmd.ExecuteScalar()) <= 0) return false;

            // Get Customer
            UInt32 customer_id;
            cmd = new MySqlCommand("SELECT customer_id FROM Customers WHERE passport_number = @passportNumber", Database.Connection);
            cmd.Parameters.AddWithValue("@passportNumber", customerID);

            customer_id = Convert.ToUInt32(cmd.ExecuteScalar());

            cmd = new MySqlCommand("SELECT name FROM Customers WHERE customer_id = " + customer_id, Database.Connection);
            txt_Status.Text = Convert.ToString(cmd.ExecuteScalar());

            // Get Data
            cmd = new MySqlCommand("SELECT * FROM Transactions WHERE customer_id = @customerId", Database.Connection);
            cmd.Parameters.AddWithValue("@customerId", customer_id);

            MySqlDataReader reader = cmd.ExecuteReader();

            // Clear the listbox before adding new items
            lbox_Logs.Items.Clear();

            // Loop through the reader and add each row to the listbox
            while (reader.Read())
            {
                // Get the values from the current row
                string transactionId = reader.GetString("transaction_id");
                string date = reader.GetString("transaction_date");
                decimal amount = reader.GetDecimal("amount");
                UInt32 currencyId = reader.GetUInt32("currency_id");

                // Create a string to represent the row
                string row = transactionId + " | " + date + " | " + amount + " | Currency ID: " + currencyId;

                // Add the row to the listbox
                lbox_Logs.Items.Add(row);
            }

            reader.Close();


            return true;
        }

        private void btn_ShowLogs_Click(object sender, EventArgs e)
        {
            if (GetTransactionLogs(tbox_CustomerID.Text.ToString()))
            {
                txt_Status.ForeColor = Color.Green;
            }
            else
            {
                txt_Status.Text = "Error: probably wrong passport number!";
                txt_Status.ForeColor = Color.Red;
                tbox_CustomerID.Text = null;
            }

        }

        private void TransactionsLog_Load(object sender, EventArgs e)
        {
            txt_Status.Text = null;
        }
    }
}
