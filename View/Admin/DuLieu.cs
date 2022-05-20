using pbl3.Admin.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pbl3
{
    public partial class DuLieu : UserControl
    {
        public DuLieu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            this.Text = "Phim";
            pbDuLieu.Controls.Clear();
            Phim phim = new Phim();
            phim.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(phim);
        }

        private void btnLoaiManHinh_Click(object sender, EventArgs e)
        {
            this.Text = "Loại Màn Hình";
            pbDuLieu.Controls.Clear();
            LoaiManHinh duLieu = new LoaiManHinh();
            duLieu.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(duLieu);
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            this.Text = "Phòng Chiếu";
            pbDuLieu.Controls.Clear();
            PhongChieu phongChieu = new PhongChieu();
            phongChieu.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(phongChieu);
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            this.Text = "Thể Loại";
            pbDuLieu.Controls.Clear();
            TheLoai theLoai = new TheLoai();
            theLoai.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(theLoai);
        }

        private void btnDinhDang_Click(object sender, EventArgs e)
        {
            this.Text = "Định Dạng";
            pbDuLieu.Controls.Clear();
            DinhDang dinhDang = new DinhDang();
            dinhDang.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(dinhDang);
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            this.Text = "Lịch Chiếu";
            pbDuLieu.Controls.Clear();
            LichChieu lichChieu = new LichChieu();
            lichChieu.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(lichChieu);
        }
    }
}
