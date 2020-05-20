using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windownApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            randomInTextbox(this);
        }
        private void randomInTextbox(Control ctr)
        {
            foreach(Control tr in ctr.Controls)
            {
                if(tr is TextBox)
                {
                    tr.Text = "aaasdasd";
                }
                else
                {
                    randomInTextbox(tr);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearAllTextBox(this);
        }
        private void clearAllTextBox(Control ctr)
        {
            foreach(Control ct in ctr.Controls)
            {
                if(ct is TextBox)
                {
                    ct.Text = "";
                }
                else
                {
                    clearAllTextBox(ct);
                }
            }
        }
    }
}
