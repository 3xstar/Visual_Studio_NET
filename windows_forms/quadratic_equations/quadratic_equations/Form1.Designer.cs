namespace quadratic_equations
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
            lblName = new Label();
            lblX1 = new Label();
            lblX2 = new Label();
            lblStatus = new Label();
            btnDecide = new Button();
            tBxA = new TextBox();
            tBxB = new TextBox();
            tBxC = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblX1, 1, 6);
            tableLayoutPanel1.Controls.Add(lblX2, 2, 6);
            tableLayoutPanel1.Controls.Add(lblStatus, 3, 6);
            tableLayoutPanel1.Controls.Add(btnDecide, 1, 7);
            tableLayoutPanel1.Controls.Add(tBxA, 2, 2);
            tableLayoutPanel1.Controls.Add(tBxB, 2, 3);
            tableLayoutPanel1.Controls.Add(tBxC, 2, 4);
            tableLayoutPanel1.Controls.Add(lbl1, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl2, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl3, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(484, 561);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblName, 3);
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI Black", 15F);
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(99, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(282, 70);
            lblName.TabIndex = 0;
            lblName.Text = "Решение квадратных\r\nуравнений";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblX1.ForeColor = SystemColors.ButtonFace;
            lblX1.Location = new Point(99, 420);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(58, 37);
            lblX1.TabIndex = 4;
            lblX1.Text = "X1:";
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblX2.ForeColor = SystemColors.ButtonFace;
            lblX2.Location = new Point(195, 420);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(58, 37);
            lblX2.TabIndex = 5;
            lblX2.Text = "X2:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStatus.ForeColor = SystemColors.ButtonFace;
            lblStatus.Location = new Point(291, 420);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 37);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Error";
            lblStatus.Visible = false;
            // 
            // btnDecide
            // 
            tableLayoutPanel1.SetColumnSpan(btnDecide, 3);
            btnDecide.Dock = DockStyle.Top;
            btnDecide.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F);
            btnDecide.Location = new Point(99, 493);
            btnDecide.Name = "btnDecide";
            btnDecide.Size = new Size(282, 56);
            btnDecide.TabIndex = 7;
            btnDecide.Text = "DECIDE";
            btnDecide.UseVisualStyleBackColor = true;
            btnDecide.Click += btnDecide_Click;
            // 
            // tBxA
            // 
            tableLayoutPanel1.SetColumnSpan(tBxA, 2);
            tBxA.Dock = DockStyle.Top;
            tBxA.Location = new Point(195, 143);
            tBxA.Name = "tBxA";
            tBxA.Size = new Size(186, 23);
            tBxA.TabIndex = 11;
            // 
            // tBxB
            // 
            tableLayoutPanel1.SetColumnSpan(tBxB, 2);
            tBxB.Dock = DockStyle.Top;
            tBxB.Location = new Point(195, 213);
            tBxB.Name = "tBxB";
            tBxB.Size = new Size(186, 23);
            tBxB.TabIndex = 12;
            // 
            // tBxC
            // 
            tableLayoutPanel1.SetColumnSpan(tBxC, 2);
            tBxC.Dock = DockStyle.Top;
            tBxC.Location = new Point(195, 283);
            tBxC.Name = "tBxC";
            tBxC.Size = new Size(186, 23);
            tBxC.TabIndex = 10;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Top;
            lbl1.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ButtonFace;
            lbl1.Location = new Point(99, 140);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(90, 32);
            lbl1.TabIndex = 1;
            lbl1.Text = "A";
            lbl1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Top;
            lbl2.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F);
            lbl2.ForeColor = SystemColors.ButtonFace;
            lbl2.Location = new Point(99, 210);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(90, 32);
            lbl2.TabIndex = 2;
            lbl2.Text = "B";
            lbl2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Top;
            lbl3.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F);
            lbl3.ForeColor = SystemColors.ButtonFace;
            lbl3.Location = new Point(99, 280);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(90, 32);
            lbl3.TabIndex = 3;
            lbl3.Text = "C";
            lbl3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(484, 561);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Квадратные уравнения";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lblX1;
        private Label lblX2;
        private Label lblStatus;
        private Button btnDecide;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tBxC;
        private TextBox tBxA;
        private TextBox tBxB;
    }
}
