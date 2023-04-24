namespace Vault
{
    partial class Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Username = new System.Windows.Forms.TextBox();
            this.txt_ConnectionStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Copyright = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Login.Location = new System.Drawing.Point(28, 141);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(230, 37);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tbox_Password
            // 
            this.tbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Password.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_Password.Location = new System.Drawing.Point(28, 103);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = 'X';
            this.tbox_Password.Size = new System.Drawing.Size(230, 23);
            this.tbox_Password.TabIndex = 1;
            this.tbox_Password.Text = "AQPdtr46kQ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // tbox_Username
            // 
            this.tbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Username.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_Username.Location = new System.Drawing.Point(28, 50);
            this.tbox_Username.Name = "tbox_Username";
            this.tbox_Username.Size = new System.Drawing.Size(230, 23);
            this.tbox_Username.TabIndex = 3;
            this.tbox_Username.Text = "sql7614096";
            // 
            // txt_ConnectionStatus
            // 
            this.txt_ConnectionStatus.AutoSize = true;
            this.txt_ConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.txt_ConnectionStatus.Location = new System.Drawing.Point(25, 190);
            this.txt_ConnectionStatus.Name = "txt_ConnectionStatus";
            this.txt_ConnectionStatus.Size = new System.Drawing.Size(40, 13);
            this.txt_ConnectionStatus.TabIndex = 5;
            this.txt_ConnectionStatus.Text = "Status.";
            this.txt_ConnectionStatus.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.txt_Copyright);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 232);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 61);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // txt_Copyright
            // 
            this.txt_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Copyright.AutoSize = true;
            this.txt_Copyright.Location = new System.Drawing.Point(10, 2);
            this.txt_Copyright.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_Copyright.Name = "txt_Copyright";
            this.txt_Copyright.Padding = new System.Windows.Forms.Padding(10);
            this.txt_Copyright.Size = new System.Drawing.Size(263, 59);
            this.txt_Copyright.TabIndex = 0;
            this.txt_Copyright.Text = "Created by: Dean Krajčovič, Amir Saade, Dolgoon Batasaikan, Jakub Országh, Roman " +
    "Szolík - All rights reserved";
            this.txt_Copyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_ConnectionStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_Username);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.btn_Login);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vault";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Username;
        private System.Windows.Forms.Label txt_ConnectionStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txt_Copyright;
        private System.Windows.Forms.Label label1;
    }
}

