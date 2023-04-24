namespace Vault
{
    partial class Exchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Status = new System.Windows.Forms.Label();
            this.tbox_CustomerID = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.Label();
            this.txt_Calculation = new System.Windows.Forms.Label();
            this.btn_Exchange = new System.Windows.Forms.Button();
            this.cbox_To = new System.Windows.Forms.ComboBox();
            this.cbox_From = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_From = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Profit = new System.Windows.Forms.Label();
            this.txt_InStock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_From)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_InStock);
            this.panel1.Controls.Add(this.txt_Profit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Status);
            this.panel1.Controls.Add(this.tbox_CustomerID);
            this.panel1.Controls.Add(this.txt_To);
            this.panel1.Controls.Add(this.txt_From);
            this.panel1.Controls.Add(this.txt_Calculation);
            this.panel1.Controls.Add(this.btn_Exchange);
            this.panel1.Controls.Add(this.cbox_To);
            this.panel1.Controls.Add(this.cbox_From);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_From);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 220);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Status.Location = new System.Drawing.Point(14, 204);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(103, 16);
            this.txt_Status.TabIndex = 12;
            this.txt_Status.Text = "Transaction Status";
            // 
            // tbox_CustomerID
            // 
            this.tbox_CustomerID.BackColor = System.Drawing.Color.Navy;
            this.tbox_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_CustomerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_CustomerID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbox_CustomerID.Location = new System.Drawing.Point(17, 167);
            this.tbox_CustomerID.Margin = new System.Windows.Forms.Padding(5);
            this.tbox_CustomerID.MaxLength = 8;
            this.tbox_CustomerID.Name = "tbox_CustomerID";
            this.tbox_CustomerID.Size = new System.Drawing.Size(163, 22);
            this.tbox_CustomerID.TabIndex = 11;
            this.tbox_CustomerID.TextChanged += new System.EventHandler(this.tbox_CustomerID_TextChanged);
            // 
            // txt_To
            // 
            this.txt_To.AutoSize = true;
            this.txt_To.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_To.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_To.Location = new System.Drawing.Point(208, 93);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(15, 17);
            this.txt_To.TabIndex = 10;
            this.txt_To.Text = "0";
            // 
            // txt_From
            // 
            this.txt_From.AutoSize = true;
            this.txt_From.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_From.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_From.Location = new System.Drawing.Point(16, 93);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(15, 17);
            this.txt_From.TabIndex = 9;
            this.txt_From.Text = "0";
            // 
            // txt_Calculation
            // 
            this.txt_Calculation.AutoSize = true;
            this.txt_Calculation.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Calculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Calculation.Location = new System.Drawing.Point(208, 33);
            this.txt_Calculation.Name = "txt_Calculation";
            this.txt_Calculation.Size = new System.Drawing.Size(17, 19);
            this.txt_Calculation.TabIndex = 8;
            this.txt_Calculation.Text = "0";
            // 
            // btn_Exchange
            // 
            this.btn_Exchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exchange.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exchange.ForeColor = System.Drawing.Color.Green;
            this.btn_Exchange.Location = new System.Drawing.Point(210, 159);
            this.btn_Exchange.Name = "btn_Exchange";
            this.btn_Exchange.Size = new System.Drawing.Size(121, 34);
            this.btn_Exchange.TabIndex = 7;
            this.btn_Exchange.Text = "Exchange";
            this.btn_Exchange.UseVisualStyleBackColor = true;
            this.btn_Exchange.Click += new System.EventHandler(this.btn_Exchange_Click);
            // 
            // cbox_To
            // 
            this.cbox_To.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbox_To.FormattingEnabled = true;
            this.cbox_To.Items.AddRange(new object[] {
            "USD",
            "JPY",
            "BGN",
            "CZK",
            "DKK",
            "GBP",
            "HUF",
            "PLN",
            "RON",
            "SEK",
            "CHF",
            "ISK",
            "NOK",
            "TRY",
            "AUD",
            "BRL",
            "CAD",
            "CNY",
            "HKD",
            "IDR",
            "ILS",
            "INR",
            "KRW",
            "MXN",
            "MYR",
            "NZD",
            "PHP",
            "EUR",
            "SGD",
            "THB",
            "ZAR"});
            this.cbox_To.Location = new System.Drawing.Point(211, 62);
            this.cbox_To.Name = "cbox_To";
            this.cbox_To.Size = new System.Drawing.Size(121, 25);
            this.cbox_To.TabIndex = 6;
            this.cbox_To.Text = "Select";
            this.cbox_To.SelectedIndexChanged += new System.EventHandler(this.cbox_To_SelectedIndexChanged);
            // 
            // cbox_From
            // 
            this.cbox_From.DisplayMember = "1";
            this.cbox_From.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbox_From.FormattingEnabled = true;
            this.cbox_From.Items.AddRange(new object[] {
            "USD",
            "JPY",
            "BGN",
            "CZK",
            "DKK",
            "GBP",
            "HUF",
            "PLN",
            "RON",
            "SEK",
            "CHF",
            "ISK",
            "NOK",
            "TRY",
            "AUD",
            "BRL",
            "CAD",
            "CNY",
            "HKD",
            "IDR",
            "ILS",
            "INR",
            "KRW",
            "MXN",
            "MYR",
            "NZD",
            "PHP",
            "EUR",
            "SGD",
            "THB",
            "ZAR"});
            this.cbox_From.Location = new System.Drawing.Point(17, 62);
            this.cbox_From.Name = "cbox_From";
            this.cbox_From.Size = new System.Drawing.Size(121, 25);
            this.cbox_From.TabIndex = 5;
            this.cbox_From.Text = "Select";
            this.cbox_From.SelectedIndexChanged += new System.EventHandler(this.cbox_From_SelectedIndexChanged);
            this.cbox_From.TextChanged += new System.EventHandler(this.cbox_From_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(161, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // num_From
            // 
            this.num_From.DecimalPlaces = 2;
            this.num_From.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_From.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_From.Location = new System.Drawing.Point(18, 33);
            this.num_From.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_From.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_From.Name = "num_From";
            this.num_From.Size = new System.Drawing.Size(120, 23);
            this.num_From.TabIndex = 1;
            this.num_From.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_From.ValueChanged += new System.EventHandler(this.num_From_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Exchange:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer ID (Passport)";
            // 
            // txt_Profit
            // 
            this.txt_Profit.AutoSize = true;
            this.txt_Profit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Profit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Profit.Location = new System.Drawing.Point(16, 119);
            this.txt_Profit.Name = "txt_Profit";
            this.txt_Profit.Size = new System.Drawing.Size(42, 17);
            this.txt_Profit.TabIndex = 14;
            this.txt_Profit.Text = "Profit:";
            // 
            // txt_InStock
            // 
            this.txt_InStock.AutoSize = true;
            this.txt_InStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_InStock.ForeColor = System.Drawing.Color.Olive;
            this.txt_InStock.Location = new System.Drawing.Point(209, 119);
            this.txt_InStock.Name = "txt_InStock";
            this.txt_InStock.Size = new System.Drawing.Size(55, 17);
            this.txt_InStock.TabIndex = 15;
            this.txt_InStock.Text = "In Stock";
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 244);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Exchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange";
            this.Load += new System.EventHandler(this.Exchange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_From)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbox_From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_To;
        private System.Windows.Forms.Label txt_Calculation;
        private System.Windows.Forms.Button btn_Exchange;
        private System.Windows.Forms.Label txt_To;
        private System.Windows.Forms.Label txt_From;
        private System.Windows.Forms.TextBox tbox_CustomerID;
        private System.Windows.Forms.Label txt_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_InStock;
        private System.Windows.Forms.Label txt_Profit;
    }
}