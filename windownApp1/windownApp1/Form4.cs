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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            veBanCo();
           
        }
        
        private Button[,] maTranNut ;
        private bool nguoiChoiA=true;
        public void veBanCo()
        {
            maTranNut = new Button[Cons.BanCo_Width, Cons.BanCo_Height];
            // Tạo Nút Cũ Để lưu trữ button kích thước cũ để đặt vị trí cho hợp lý
            Button btnCu = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0;i < Cons.BanCo_Width; i++)
            {
                for (int j = 0;j < Cons.BanCo_Height; j++)
                {
                    Button btn = new Button()
                    {

                        Width = Cons.Co_Width,
                        Height = Cons.Co_Height,
                        Location = new Point(btnCu.Location.X + btnCu.Width, btnCu.Location.Y)
                    };
                    //Them nut vao mang 2 chieu
                    maTranNut[i, j] = btn;
                    //lấy vị trí của button thứ i j thì lưu vào tag
                    maTranNut[i, j].Tag = i + "," + j;

                    btn.Click += btn_Click;
                    btnCu = btn;
                    pnBanCo.Controls.Add(btn);
                    
                }
                // btnCu.Location.Y + Cons.Co_Height ý là vị trí của btn cũ được lưu trữ vị trí mới 
                // có nghĩa là x : 0,y : chiều cao btn mặc định + vị trí của btn cũ 
                btnCu.Location = new Point(0, btnCu.Location.Y+Cons.Co_Height);
                //và nút cũ nãy sẽ thiết lập lại = 0 để lưu trữ những button khác
                btnCu.Height = 0;
                btnCu.Width = 0;
            }
        }
        private void bntBatDau_Click(object sender, EventArgs e)
        {
            bntBatDau.Enabled = false;
            pnBanCo.Visible = true;
            tbNguoiChoi1.Text = "Người Chơi 1";
            tbNguoiChoi1.Enabled = false;
            tbNguoiChoi2.Text = "Người Chơi 2";
            tbNguoiChoi2.Enabled = false;
            timer1.Start();
        }
        public void timer1_Tick(object sender,EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void btnChoiLai_Click(object sender,EventArgs e)
        {
            pnBanCo.Controls.Clear();
            veBanCo();
            pnBanCo.Enabled = true;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if(btn.Text=="")
            {
                if(nguoiChoiA== true)
                {
                    btn.Text = "O";
                    tbNguoiChoi1.BackColor = Color.Red;
                    tbNguoiChoi2.BackColor = Color.White;
                    nguoiChoiA = false;
                }
                else
                {
                    btn.Text = "X";
                    tbNguoiChoi2.BackColor = Color.Purple;
                    tbNguoiChoi1.BackColor = Color.White;
                    nguoiChoiA = true;
                }
            }
            //kiểm tra thắng game
            if (KetThuc(btn))
            {

                MessageBox.Show("Bạn đã thắng");
                pnBanCo.Enabled = false;
            }
        }
        //--
        //Phân Định Thắng Thua
        private bool KetThuc(Button btn)
        {
            String[] M = btn.Tag.ToString().Split(',');
            Point xy = new Point(int.Parse(M[0]),int.Parse(M[1]));

            return KetThucDuongNgang(xy) || KetThucDuongDoc(xy) || KetThucDuongCheoChinh(xy) || KetThucDuongCheoPhu(xy);
        }
        private bool KetThucDuongCheoChinh(Point xy)
        {

            int x = xy.X;
            int y = xy.Y;
            String checkDau = maTranNut[x, y].Text;
            int dem = 0;
            while (y >= 1 && x >=1  && maTranNut[x -1, y - 1].Text.Equals(checkDau))
            {
                x -= 1;
                y -= 1;
            }
            dem = 1;
            while (y <= pnBanCo.Width && x <= pnBanCo.Width && maTranNut[x + 1, y + 1].Text.Equals(checkDau))
            {
                dem++;
                y += 1;
                x += 1;
            }
            return dem >= 5;
        }
        private bool KetThucDuongCheoPhu(Point xy)
        {
            int x = xy.X;
            int y = xy.Y;
            String checkDau = maTranNut[x, y].Text;
            int dem = 0;
            //quay ve diem dau
            while (y >= 1 && x >= 1 && maTranNut[x - 1, y + 1].Text.Equals(checkDau))
            {
                x -= 1;
                y += 1;
            }
            dem = 1;
            while (y <= pnBanCo.Width && x <= pnBanCo.Width && maTranNut[x + 1, y - 1].Text.Equals(checkDau))
            {
                dem++;
                y -= 1;
                x += 1;
            }
            return dem >= 5;
        }
        private bool KetThucDuongNgang(Point xy)
        {
            int x = xy.X;
            int y = xy.Y;
            String checkDau = maTranNut[x, y].Text;
            int dem = 0;
            while (y >= 1 && maTranNut[x, y - 1].Text.Equals(checkDau))
            {
                y -= 1;
            }
            dem = 1;
            while (y <= pnBanCo.Width && maTranNut[x, y + 1].Text.Equals(checkDau))
            {
                dem++;
                y += 1;
            }
            return dem >= 5;
        }
        private bool KetThucDuongDoc(Point xy)
        {
            int x = xy.X;
            int y = xy.Y;
            String checkDau = maTranNut[x, y].Text;
            int dem = 0;
            while (x >= 1 && maTranNut[x - 1, y].Text.Equals(checkDau))
            {
                x -= 1;
            }
            dem = 1;
            while (x <= pnBanCo.Width && maTranNut[x + 1, y].Text.Equals(checkDau))
            {
                dem++;
                x += 1;
            }
            return dem >= 5;
        }
    }
}
