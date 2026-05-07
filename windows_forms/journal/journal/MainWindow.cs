using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace journal
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Parser.getData();
            lblName.Text = Parser.name;
            lblCoins.Text = Parser.coins;
            lblGems.Text = Parser.gems;
            lblAllHomework.Text = Parser.allHomeWorks;
            lblCheckedHomework.Text = Parser.checkedHomeWorks;
            lblPassedHomework.Text = Parser.passedHomeWorks;
            lblDeletedHomework.Text = Parser.deletedHomeWorks;
            lblRating.Text = Parser.rating;
            lblGrade.Text = Parser.grade;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Parser.Update();
            lblName.Text = Parser.name;
            lblCoins.Text = Parser.coins;
            lblGems.Text = Parser.gems;
            lblAllHomework.Text = Parser.allHomeWorks;
            lblCheckedHomework.Text = Parser.checkedHomeWorks;
            lblPassedHomework.Text = Parser.passedHomeWorks;
            lblDeletedHomework.Text = Parser.deletedHomeWorks;
            lblRating.Text = Parser.rating;
            lblGrade.Text = Parser.grade;
        }
    }
}
