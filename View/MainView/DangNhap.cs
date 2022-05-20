using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuSettiing.Enabled=false;
            Database database = new Database();
            this.Hide();
            database.ShowDialog();
            this.Show();
            mnuSettiing.Enabled = true;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if (txtUserName.Text == "1" && txtPasswork.Text == "1")
            {
                BangDieuKhien bangDieuKhien = new BangDieuKhien();
                this.Hide();
                bangDieuKhien.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("SAI TÊN TÀI KHOẢN HOẶC MẬT KHẨU!!!!", "THÔNG BÁO");

            }
            btnLogin.Enabled = true;
        }
    }
}
