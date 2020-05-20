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
    public partial class Form5_Caro_TruyenMangSoNguyen : Form
    {
        public Form5_Caro_TruyenMangSoNguyen()
        {
            InitializeComponent();
            
        }
        
        private int[,] BanCo;
        private bool NguoiChoiThuNhat = true;

        public void veBanCo()
        {
            BanCo = new int[20, 20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button btn = TaoNut(i, j);
                    BanCo[i, j] = -1;
                    this.Controls.Add(btn);
                }
            }
        }
        private Button TaoNut(int i,int j)
        {
            Button nut = new Button();
            nut.Width = nut.Height = 25;
            nut.Location = new Point(j * 25, i * 25);
            nut.Click += nut_click;
            nut.Tag = new Point(i, j);
            return nut;
        }
        void nut_click(object sender,EventArgs e)
        {
            Button nut = (Button)sender;
            Point ToaDo = (Point)nut.Tag;
            if(nut.Text!=String.Empty)
            {
                return;
            }
            tbNguoiChoi1.BackColor = Color.Blue;
            if (NguoiChoiThuNhat)
            {
                nut.Text = "O";
                nut.ForeColor = Color.Blue;
                tbNguoiChoi1.BackColor = Color.Red;
                tbNguoiChoi2.BackColor = Color.White;
                BanCo[ToaDo.X, ToaDo.Y] = 1;
               
            }
            else
            {
                nut.Text = "X";
                nut.ForeColor = Color.Red;
                tbNguoiChoi2.BackColor = Color.Blue;
                tbNguoiChoi1.BackColor = Color.White;
                BanCo[ToaDo.X, ToaDo.Y] = 0;
                
            }
            
            if(IsWinGame(BanCo, ToaDo))
            {
                MessageBox.Show("Game Over!!!");
                return;
            }
            NguoiChoiThuNhat = !NguoiChoiThuNhat;
        }
        private bool IsWinGame(int[,] banCo,Point ToaDo)
        {

            return XetHangDoc(banCo,ToaDo)
                || XetHangNgang(banCo, ToaDo)
                || XetDuongCheoChinh(banCo, ToaDo)
                || XetDuongCheoPhu(banCo, ToaDo);
        }
        private bool XetHangDoc(int[,] banCo, Point toaDo)
        {
            int x = toaDo.X;
            int y = toaDo.Y;
            int coHienTai = banCo[x, y];
            while (x >= 1 && banCo[x - 1, y] == coHienTai)
            {
                x -= 1;
            }
            int dem = 1;
            while (x <= 18 && banCo[x + 1, y] == coHienTai)
            {
                x+=1;
                dem++;
            }
            if (dem >= 5)
                return true;
            return false;
        }
        private bool XetHangNgang(int[,] banCo, Point ToaDo)
        {
            int x = ToaDo.X;
            int y = ToaDo.Y;
            int coHienTai = banCo[x, y];
            while (x >= 1 && banCo[x , y - 1] == coHienTai)
            {
                y -= 1;
            }
            int dem = 1;
            while (x <= 18 && banCo[x, y + 1] == coHienTai)
            {
                y += 1;
                dem++;
            }
            if (dem >= 5)
                return true;
            return false;
        }
        private bool XetDuongCheoChinh(int[,] banCo, Point ToaDo)
        {
            int x = ToaDo.X;
            int y = ToaDo.Y;
            int coHienTai = banCo[x, y];
            while (x >= 1 && banCo[x-1, y - 1] == coHienTai)
            {              
                x -= 1;
                y -= 1;
            }
            int dem = 1;
            while (x <= 18 && banCo[x + 1, y + 1] == coHienTai)
            {
                x += 1;
                y += 1;
                dem++;
            }
            if (dem >= 5)
                return true;
            return false;
        }
        private bool XetDuongCheoPhu(int[,] banCo, Point ToaDo)
        {
            int x = ToaDo.X;
            int y = ToaDo.Y;
            int coHienTai = banCo[x, y];
            while (x >= 1 && banCo[x - 1, y + 1] == coHienTai)
            {
                x += 1;
                y -= 1;
            }
            int dem = 1;
            while (x <= 18 && banCo[x + 1, y - 1] == coHienTai)
            {
                x -= 1;
                y += 1;
                dem++;
            }
            if (dem >= 5)
                return true;
            return false;
        }
        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            veBanCo();
            
        }
    }
}
