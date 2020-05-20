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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initMyComponent();
        }
        public void initMyComponent()
        {
            Button btn = new Button();
            btn.Name = "b";
            btn.Text = "Click ";
            btn.Size = new Size(50, 50);
            btn.Left = 30;
            btn.Top = 50;
            btn.Click += new EventHandler(btn_Click);
            this.Controls.Add(btn);
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oke");
        }
    }
}
