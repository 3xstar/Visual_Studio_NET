namespace journal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblError = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tBxLogin = new TextBox();
            tBxPassword = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblError, 1, 7);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tBxLogin, 0, 4);
            tableLayoutPanel1.Controls.Add(tBxPassword, 0, 6);
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(75, 100, 75, 100);
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.493075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8975067F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.75623274F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4044323F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.812261F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0919533F));
            tableLayoutPanel1.Size = new Size(384, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblError, 2);
            lblError.Dock = DockStyle.Fill;
            lblError.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(136, 370);
            lblError.Name = "lblError";
            lblError.Size = new Size(110, 31);
            lblError.TabIndex = 3;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 278);
            label2.Name = "label2";
            label2.Size = new Size(110, 52);
            label2.TabIndex = 4;
            label2.Text = "password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 189);
            label3.Name = "label3";
            label3.Size = new Size(110, 61);
            label3.TabIndex = 5;
            label3.Text = "login";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 4);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(78, 103);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 3);
            pictureBox1.Size = new Size(228, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tBxLogin
            // 
            tableLayoutPanel1.SetColumnSpan(tBxLogin, 4);
            tBxLogin.Dock = DockStyle.Fill;
            tBxLogin.Location = new Point(78, 253);
            tBxLogin.Name = "tBxLogin";
            tBxLogin.Size = new Size(228, 23);
            tBxLogin.TabIndex = 7;
            // 
            // tBxPassword
            // 
            tableLayoutPanel1.SetColumnSpan(tBxPassword, 4);
            tBxPassword.Dock = DockStyle.Fill;
            tBxPassword.Location = new Point(78, 333);
            tBxPassword.Name = "tBxPassword";
            tBxPassword.Size = new Size(228, 23);
            tBxPassword.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SlateGray;
            tableLayoutPanel1.SetColumnSpan(btnLogin, 2);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(136, 404);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 54);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(344, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 40);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Journal";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClose;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblError;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox tBxLogin;
        private TextBox tBxPassword;
        private Button btnLogin;
    }
}
