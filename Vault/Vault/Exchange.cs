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
    public partial class Exchange : Form
    {
        double exchangeFrom, exchangeTo, exchangeFinal, exchangeProfit;
        public Exchange()
        {
            InitializeComponent();
        }

        private void Recalculate()
        {
            double complete = (Convert.ToDouble(num_From.Value) / exchangeFrom) * exchangeTo;
            exchangeFinal = complete * 0.9;
            exchangeProfit = complete * 0.1;

            txt_Calculation.Text = Math.Round(exchangeFinal, 3).ToString();
            txt_Profit.Text = "Profit 10%: " + Math.Round(exchangeProfit, 3).ToString();
        }

        private void num_From_ValueChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void cbox_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeFrom = Database.GetCurrencyRate(cbox_From.Text);
            txt_From.Text = "Rate: " + exchangeFrom.ToString();
            Recalculate();
        }

        private void Exchange_Load(object sender, EventArgs e)
        {
            txt_Status.Text = null;
            if (cbox_From.Items.Count > 0) cbox_From.SelectedIndex = 0;
            if (cbox_To.Items.Count > 1) cbox_To.SelectedIndex = 1;
            cbox_From.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_To.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbox_From_TextChanged(object sender, EventArgs e)
        {
            exchangeFrom = Database.GetCurrencyRate(cbox_From.Text);
            txt_From.Text = "Rate: " + exchangeFrom.ToString();
            Recalculate();
        }

        private void tbox_CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbox_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeTo = Database.GetCurrencyRate(cbox_To.Text);
            txt_To.Text = "Rate: " + exchangeTo.ToString();
            Recalculate();
        }

        private void btn_Exchange_Click(object sender, EventArgs e)
        {
            if (num_From.Value <= 0 || tbox_CustomerID.Text == null) return;

            bool success = Database.LogTransaction(cbox_From.Text, Convert.ToDouble(num_From.Value), tbox_CustomerID.Text);
            if (success)
            {
                txt_Status.Text = "Transaction completed!";
                txt_Status.ForeColor = Color.Green;
            }
            else
            {
                txt_Status.Text = "Transaction failed! Make sure, the customer ID is correct.";
                txt_Status.ForeColor = Color.Red;
            }
            tbox_CustomerID.Text = null;
            num_From.Value = 1;
        }
    }
}
