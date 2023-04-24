namespace Vault
{
    partial class TransactionsLog
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_ShowLogs = new System.Windows.Forms.Button();
            this.lbox_Logs = new System.Windows.Forms.ListBox();
            this.txt_Status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Status);
            this.panel1.Controls.Add(this.btn_ShowLogs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbox_CustomerID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer ID (Passport)";
            // 
            // tbox_CustomerID
            // 
            this.tbox_CustomerID.BackColor = System.Drawing.Color.Navy;
            this.tbox_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_CustomerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_CustomerID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbox_CustomerID.Location = new System.Drawing.Point(14, 46);
            this.tbox_CustomerID.Margin = new System.Windows.Forms.Padding(5);
            this.tbox_CustomerID.MaxLength = 8;
            this.tbox_CustomerID.Name = "tbox_CustomerID";
            this.tbox_CustomerID.Size = new System.Drawing.Size(163, 22);
            this.tbox_CustomerID.TabIndex = 14;
            // 
            // btn_ShowLogs
            // 
            this.btn_ShowLogs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_ShowLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowLogs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ShowLogs.ForeColor = System.Drawing.Color.Green;
            this.btn_ShowLogs.Location = new System.Drawing.Point(362, 34);
            this.btn_ShowLogs.Name = "btn_ShowLogs";
            this.btn_ShowLogs.Size = new System.Drawing.Size(121, 34);
            this.btn_ShowLogs.TabIndex = 16;
            this.btn_ShowLogs.Text = "Show Log";
            this.btn_ShowLogs.UseVisualStyleBackColor = true;
            this.btn_ShowLogs.Click += new System.EventHandler(this.btn_ShowLogs_Click);
            // 
            // lbox_Logs
            // 
            this.lbox_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Logs.FormattingEnabled = true;
            this.lbox_Logs.Location = new System.Drawing.Point(0, 100);
            this.lbox_Logs.Margin = new System.Windows.Forms.Padding(10);
            this.lbox_Logs.Name = "lbox_Logs";
            this.lbox_Logs.Size = new System.Drawing.Size(495, 494);
            this.lbox_Logs.TabIndex = 1;
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Status.Location = new System.Drawing.Point(12, 75);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(103, 16);
            this.txt_Status.TabIndex = 17;
            this.txt_Status.Text = "Transaction Status";
            // 
            // TransactionsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 594);
            this.Controls.Add(this.lbox_Logs);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionsLog";
            this.Text = "TransactionsLog";
            this.Load += new System.EventHandler(this.TransactionsLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_CustomerID;
        private System.Windows.Forms.Button btn_ShowLogs;
        private System.Windows.Forms.ListBox lbox_Logs;
        private System.Windows.Forms.Label txt_Status;
    }
}