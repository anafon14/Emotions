using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotions
{
    public partial class frmEmotions : Form
    {
        public frmEmotions()
        {
            InitializeComponent();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Me too. Because I don't have class tomorrow!";
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            lblResult.Text = "I understand. You have two classes with Mr.Hardman!?";
        }

        private void btnScared_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Then you have a math test tomorrow!";
        }

        private void btnExcited_Click(object sender, EventArgs e)
        {
            lblResult.Text = "You must be moving out of Winnipeg then!";
        }

        private void btnBored_Click(object sender, EventArgs e)
        {
            lblResult.Text = "My guess is that you are studying then!";
        }

        private void btnTired_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Had to go to school today eh?";
        }
    }
}
