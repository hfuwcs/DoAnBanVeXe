using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class DangNhap : Form
    {
        public DangNhap instance;
        public TextBox tb1;
        public TextBox tb2;
        public DangNhap()
        {
            InitializeComponent();
            instance = this;
            tb1 = txtBox_Email;
            tb2 = txtBox_Pass;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Pass_Enter(object sender, EventArgs e)
        {
            txtBox_Pass.Text = "";

            txtBox_Pass.ForeColor = Color.Black;

            txtBox_Pass.UseSystemPasswordChar = true;
        }

        private void txtBox_Pass_Leave(object sender, EventArgs e)
        {
            if (txtBox_Pass.Text.Length == 0)
            {
                txtBox_Pass.ForeColor = Color.Gray;

                txtBox_Pass.Text = "Enter password";

                txtBox_Pass.UseSystemPasswordChar = false;

                SelectNextControl(txtBox_Pass, true, true, false, true);
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Point point = new Point(56, 468);
            
            BanVeXe.instance.button_QuanLyChuyen.Visible = true;
            BanVeXe.instance.button_Thoat.Location = point;
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_ThoatDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_DoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.Show();
        }
    }
}
