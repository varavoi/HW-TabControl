using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_TabControl
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            FillBox(TxtSize);
        }
        private void FillBox(ComboBox ch)
        {
            for(int i = 7; i < 24; i++)
            {
                ch.Items.Add(i);
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void RBtext1_CheckedChanged(object sender, EventArgs e)
        {
            SHOW.Text = RBtext1.Text;
        }

        private void SHOW_Click(object sender, EventArgs e)
        {

        }

        private void RBtext2_CheckedChanged(object sender, EventArgs e)
        {
            SHOW.Text = RBtext2.Text;
        }

        private void RBred_CheckedChanged(object sender, EventArgs e)
        {
            SHOW.ForeColor = Color.Red;
        }

        private void RByellow_CheckedChanged(object sender, EventArgs e)
        {
            SHOW.ForeColor = Color.Yellow;
        }

        private void RBblue_CheckedChanged(object sender, EventArgs e)
        {
            SHOW.ForeColor = Color.Blue;
        }

        private void TxtSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(TxtSize.SelectedItem.ToString());
            SHOW.Font = new Font(SHOW.Font.FontFamily,size,SHOW.Font.Style);
        }
    }
}
