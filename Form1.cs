using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class BanVeXe : Form
    {
        BanVeXe ths;
        public static BanVeXe instance;
        public Button button_Thoat;
        public Button button_QuanLyChuyen;
        public BanVeXe()
        {
            InitializeComponent();
            instance = this;
            button_Thoat = btn_Thoat;
            button_QuanLyChuyen = btn_QuanLyChuyen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No) { 
                    e.Cancel= true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            Point point = new Point(56, 468);
            btn_Thoat.Location = point;
            btn_QuanLyChuyen.Visible = true;
        }

        private void btn_MuaVe_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.Show();
        }
    }
}
