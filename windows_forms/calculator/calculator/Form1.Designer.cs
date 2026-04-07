namespace calculator
{
    partial class FormMain
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
            lblName = new Label();
            lbl1 = new Label();
            tBxFirstNum = new TextBox();
            lbl2 = new Label();
            tBxSecondNum = new TextBox();
            lblAnswer = new Label();
            lbl3 = new Label();
            btnDifference = new Button();
            btnDecide = new Button();
            btnDivide = new Button();
            btnMultiplay = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(424, 37);
            lblName.TabIndex = 1;
            lblName.Text = "Calculator";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl1
            // 
            lbl1.Dock = DockStyle.Top;
            lbl1.Font = new Font("Dubai", 14F);
            lbl1.Location = new Point(30, 67);
            lbl1.Name = "lbl1";
            lbl1.Padding = new Padding(100, 0, 0, 0);
            lbl1.Size = new Size(424, 29);
            lbl1.TabIndex = 2;
            lbl1.Text = "NUMBER 1:";
            lbl1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tBxFirstNum
            // 
            tBxFirstNum.Dock = DockStyle.Top;
            tBxFirstNum.Location = new Point(30, 96);
            tBxFirstNum.MaximumSize = new Size(300, 0);
            tBxFirstNum.Name = "tBxFirstNum";
            tBxFirstNum.PlaceholderText = "Enter the number: ";
            tBxFirstNum.Size = new Size(300, 23);
            tBxFirstNum.TabIndex = 3;
            // 
            // lbl2
            // 
            lbl2.Dock = DockStyle.Top;
            lbl2.Font = new Font("Dubai", 14F);
            lbl2.Location = new Point(30, 119);
            lbl2.Name = "lbl2";
            lbl2.Padding = new Padding(100, 0, 0, 0);
            lbl2.Size = new Size(424, 29);
            lbl2.TabIndex = 4;
            lbl2.Text = "NUMBER 2:";
            lbl2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tBxSecondNum
            // 
            tBxSecondNum.Dock = DockStyle.Top;
            tBxSecondNum.Location = new Point(30, 148);
            tBxSecondNum.MaximumSize = new Size(300, 0);
            tBxSecondNum.Name = "tBxSecondNum";
            tBxSecondNum.PlaceholderText = "Enter the number: ";
            tBxSecondNum.Size = new Size(300, 23);
            tBxSecondNum.TabIndex = 5;
            // 
            // lblAnswer
            // 
            lblAnswer.Dock = DockStyle.Top;
            lblAnswer.Font = new Font("Dubai", 14F, FontStyle.Bold);
            lblAnswer.Location = new Point(30, 200);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(424, 29);
            lblAnswer.TabIndex = 8;
            lblAnswer.Text = "Answer";
            lblAnswer.TextAlign = ContentAlignment.TopCenter;
            lblAnswer.Click += lblAnswer_Click;
            // 
            // lbl3
            // 
            lbl3.Dock = DockStyle.Top;
            lbl3.Font = new Font("Dubai", 14F, FontStyle.Bold);
            lbl3.Location = new Point(30, 171);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(424, 29);
            lbl3.TabIndex = 6;
            lbl3.Text = "DESISION";
            lbl3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDifference
            // 
            btnDifference.BackColor = Color.Navy;
            btnDifference.Dock = DockStyle.Top;
            btnDifference.FlatStyle = FlatStyle.Flat;
            btnDifference.Font = new Font("Dubai", 15F, FontStyle.Bold);
            btnDifference.ForeColor = SystemColors.ButtonFace;
            btnDifference.Location = new Point(30, 229);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new Size(424, 50);
            btnDifference.TabIndex = 10;
            btnDifference.Text = "DIFFERENCE";
            btnDifference.UseVisualStyleBackColor = false;
            btnDifference.Click += btnDifference_click;
            // 
            // btnDecide
            // 
            btnDecide.BackColor = Color.Navy;
            btnDecide.Dock = DockStyle.Top;
            btnDecide.FlatStyle = FlatStyle.Flat;
            btnDecide.Font = new Font("Dubai", 15F, FontStyle.Bold);
            btnDecide.ForeColor = SystemColors.ButtonFace;
            btnDecide.Location = new Point(30, 279);
            btnDecide.Name = "btnDecide";
            btnDecide.Size = new Size(424, 50);
            btnDecide.TabIndex = 11;
            btnDecide.Text = "SUM";
            btnDecide.UseVisualStyleBackColor = false;
            btnDecide.Click += btnDecide_click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Navy;
            btnDivide.Dock = DockStyle.Top;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Dubai", 15F, FontStyle.Bold);
            btnDivide.ForeColor = SystemColors.ButtonFace;
            btnDivide.Location = new Point(30, 329);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(424, 50);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "DIVIDE";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_click;
            // 
            // btnMultiplay
            // 
            btnMultiplay.BackColor = Color.Navy;
            btnMultiplay.Dock = DockStyle.Top;
            btnMultiplay.FlatStyle = FlatStyle.Flat;
            btnMultiplay.Font = new Font("Dubai", 15F, FontStyle.Bold);
            btnMultiplay.ForeColor = SystemColors.ButtonFace;
            btnMultiplay.Location = new Point(30, 379);
            btnMultiplay.Name = "btnMultiplay";
            btnMultiplay.Size = new Size(424, 50);
            btnMultiplay.TabIndex = 13;
            btnMultiplay.Text = "MULTIPLAY";
            btnMultiplay.UseVisualStyleBackColor = false;
            btnMultiplay.Click += btnMultiplay_click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 474);
            Controls.Add(btnMultiplay);
            Controls.Add(btnDivide);
            Controls.Add(btnDecide);
            Controls.Add(btnDifference);
            Controls.Add(lblAnswer);
            Controls.Add(lbl3);
            Controls.Add(tBxSecondNum);
            Controls.Add(lbl2);
            Controls.Add(tBxFirstNum);
            Controls.Add(lbl1);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Padding = new Padding(30);
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lbl1;
        private TextBox tBxFirstNum;
        private Label lbl2;
        private Label label2;
        private TextBox tBxSecondNum;
        private Label label1;
        private Label lblAnswer;
        private Label lbl3;
        private Button button1;
        private Button btnDifference;
        private Button btnDecide;
        private Button btnDivide;
        private Button btnMultiplay;
    }
}
