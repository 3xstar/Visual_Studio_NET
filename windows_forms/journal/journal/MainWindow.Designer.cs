namespace journal
{
    partial class MainWindow
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
            panel1 = new Panel();
            btnUpdate = new Button();
            btnClose = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label12 = new Label();
            lblCheckedHomework = new Label();
            lblAllHomework = new Label();
            label9 = new Label();
            lblPassedHomework = new Label();
            label14 = new Label();
            lblDeletedHomework = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblName = new Label();
            lblGrade = new Label();
            lblRating = new Label();
            label11 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblCoins = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblGems = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 40);
            panel1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(266, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(72, 32);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.46875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.28125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 5);
            tableLayoutPanel1.Controls.Add(groupBox2, -1, 4);
            tableLayoutPanel1.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.Size = new Size(384, 521);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Teal;
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 315);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 4);
            groupBox1.Size = new Size(378, 203);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reviews";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(groupBox2, 4);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 159);
            groupBox2.Name = "groupBox2";
            tableLayoutPanel1.SetRowSpan(groupBox2, 3);
            groupBox2.Size = new Size(378, 150);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "HomeWork";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.2043F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.98924732F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.27957F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.52688169F));
            tableLayoutPanel2.Controls.Add(label12, 2, 0);
            tableLayoutPanel2.Controls.Add(lblCheckedHomework, 3, 0);
            tableLayoutPanel2.Controls.Add(lblAllHomework, 1, 0);
            tableLayoutPanel2.Controls.Add(label9, 0, 1);
            tableLayoutPanel2.Controls.Add(lblPassedHomework, 1, 1);
            tableLayoutPanel2.Controls.Add(label14, 2, 1);
            tableLayoutPanel2.Controls.Add(lblDeletedHomework, 3, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(372, 117);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.Location = new Point(186, 0);
            label12.Name = "label12";
            label12.Size = new Size(136, 28);
            label12.TabIndex = 13;
            label12.Text = "ПРОВЕРЕНО:";
            // 
            // lblCheckedHomework
            // 
            lblCheckedHomework.AutoSize = true;
            lblCheckedHomework.Location = new Point(347, 0);
            lblCheckedHomework.Name = "lblCheckedHomework";
            lblCheckedHomework.Size = new Size(22, 28);
            lblCheckedHomework.TabIndex = 14;
            lblCheckedHomework.Text = "0";
            // 
            // lblAllHomework
            // 
            lblAllHomework.AutoSize = true;
            lblAllHomework.Location = new Point(160, 0);
            lblAllHomework.Name = "lblAllHomework";
            lblAllHomework.Size = new Size(20, 28);
            lblAllHomework.TabIndex = 9;
            lblAllHomework.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 58);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 10;
            label9.Text = "СДАНО:";
            // 
            // lblPassedHomework
            // 
            lblPassedHomework.AutoSize = true;
            lblPassedHomework.Location = new Point(160, 58);
            lblPassedHomework.Name = "lblPassedHomework";
            lblPassedHomework.Size = new Size(20, 28);
            lblPassedHomework.TabIndex = 18;
            lblPassedHomework.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(186, 58);
            label14.Name = "label14";
            label14.Size = new Size(115, 28);
            label14.TabIndex = 15;
            label14.Text = "УДАЛЕНО:";
            // 
            // lblDeletedHomework
            // 
            lblDeletedHomework.AutoSize = true;
            lblDeletedHomework.Location = new Point(347, 58);
            lblDeletedHomework.Name = "lblDeletedHomework";
            lblDeletedHomework.Size = new Size(22, 28);
            lblDeletedHomework.TabIndex = 11;
            lblDeletedHomework.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 8;
            label7.Text = "ВСЕГО:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(144, 3);
            groupBox3.Name = "groupBox3";
            tableLayoutPanel1.SetRowSpan(groupBox3, 3);
            groupBox3.Size = new Size(237, 150);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Info";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblName, 1, 0);
            tableLayoutPanel3.Controls.Add(lblGrade, 1, 1);
            tableLayoutPanel3.Controls.Add(lblRating, 1, 2);
            tableLayoutPanel3.Controls.Add(label11, 0, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 1);
            tableLayoutPanel3.Controls.Add(label16, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(231, 117);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(118, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 28);
            lblName.TabIndex = 0;
            lblName.Text = "info";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(118, 38);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(50, 28);
            lblGrade.TabIndex = 1;
            lblGrade.Text = "info";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(118, 76);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(24, 28);
            lblRating.TabIndex = 2;
            lblRating.Text = "1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(64, 28);
            label11.TabIndex = 3;
            label11.Text = "name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 38);
            label15.Name = "label15";
            label15.Size = new Size(66, 28);
            label15.TabIndex = 4;
            label15.Text = "grade";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 76);
            label16.Name = "label16";
            label16.Size = new Size(69, 28);
            label16.TabIndex = 5;
            label16.Text = "rating";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(128, 128, 255);
            tableLayoutPanel1.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            tableLayoutPanel1.SetRowSpan(groupBox4, 3);
            groupBox4.Size = new Size(135, 150);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gems | Coins";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblCoins, 1, 1);
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(lblGems, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 27);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(129, 120);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblCoins
            // 
            lblCoins.AutoSize = true;
            lblCoins.Dock = DockStyle.Fill;
            lblCoins.Location = new Point(67, 60);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(59, 60);
            lblCoins.TabIndex = 1;
            lblCoins.Text = "0";
            lblCoins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.gem;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.coin;
            pictureBox2.Location = new Point(3, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblGems
            // 
            lblGems.Anchor = AnchorStyles.Left;
            lblGems.AutoSize = true;
            lblGems.Location = new Point(67, 17);
            lblGems.Name = "lblGems";
            lblGems.Size = new Size(22, 25);
            lblGems.TabIndex = 4;
            lblGems.Text = "0";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(384, 561);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainWindow";
            Text = "MainWindow";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdate;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label lblAllHomework;
        private Label label9;
        private Label lblDeletedHomework;
        private Label label12;
        private Label lblCheckedHomework;
        private Label label14;
        private Label lblPassedHomework;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblName;
        private Label lblGrade;
        private Label lblRating;
        private Label label11;
        private Label label15;
        private Label label16;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label lblCoins;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblGems;
    }
}