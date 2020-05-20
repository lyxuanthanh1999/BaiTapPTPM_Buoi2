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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            initMyComponent();
        }
        public void initMyComponent()
        {
            
            for(int i= 0; i < 10;i++)
            {
                Button btn = new Button();
                btn.Name = "button" + i;
                btn.Text = "Nút " + i;
                btn.Size = new Size(50, 50);
                btn.Left = i*(btn.Width + 50);
                btn.Click += new EventHandler(btn_Click);
                this.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oke");
        }
    }
}
