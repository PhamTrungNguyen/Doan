using DoAn.BLL;
using pbl3.DTO;
using pbl3.View.Admin.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.View.Admin.DuLieu
{
    public partial class PhongChieu : UserControl
    {
        public PhongChieu()
        {
            InitializeComponent();
            LoadLMH();
        }
        public void LoadLMH()
        {
            cbbManHinh.Items.AddRange(QLBLL.Instance.GetCBBLoaiMH().ToArray());
        }
        public void Reload()
        {
            dgvPhongChieu.DataSource = QLBLL.Instance.ShowPhongChieu();
        }
        private void btnPhongChieuThemXem_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnPhongChieuThem_Click(object sender, EventArgs e)
        {
            AddPhongChieu addpc = new AddPhongChieu("");
            addpc.Show();
            addpc.d = new AddPhongChieu.Mydel(Reload);
        }

        private void dgvPhongChieu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPhongChieu.SelectedRows.Count == 1)
            {
                txtPhongChieuMaPhong.Enabled = false;
                txtPhongChieuMaPhong.Text = dgvPhongChieu.SelectedRows[0].Cells["IDPhongChieu"].Value.ToString();
                txtPhongChieuTenPhong.Text = dgvPhongChieu.SelectedRows[0].Cells["TenPhong"].Value.ToString();
                txtPhongChieuChoNgoi.Text = dgvPhongChieu.SelectedRows[0].Cells["SoChoNgoi"].Value.ToString();
                txtPhongChieuTinhTrang.Text = dgvPhongChieu.SelectedRows[0].Cells["TinhTrang"].Value.ToString();
                txtPhongChieuSoHangGhe.Text = dgvPhongChieu.SelectedRows[0].Cells["SoHangGhe"].Value.ToString();
                txtPhongChieuGheMoiHang.Text = dgvPhongChieu.SelectedRows[0].Cells["SoGhe1Hang"].Value.ToString();
                string id = dgvPhongChieu.SelectedRows[0].Cells["IDManHinh"].Value.ToString();
                foreach (CBBLoaiManHinh r in cbbManHinh.Items)
                {
                    if (r.value == id)
                    {
                        cbbManHinh.SelectedItem = r;
                    }
                }

            }
        }

        private void btnPhongChieuThemXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhongChieu.SelectedRows.Count == 1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    string mapc = dgvPhongChieu.SelectedRows[0].Cells["IDPhongChieu"].Value.ToString();
                    QLBLL.Instance.DelPhongChieu(mapc);
                    Reload();
                }
            }
        }

        private void btnPhongChieuThemSua_Click(object sender, EventArgs e)
        {
            if (dgvPhongChieu.SelectedRows.Count == 1)
            {
                string IDPC = dgvPhongChieu.SelectedRows[0].Cells["IDPhongChieu"].Value.ToString();
                AddPhongChieu addpc = new AddPhongChieu(IDPC);
                addpc.Show();
                addpc.d = new AddPhongChieu.Mydel(Reload);
            }
        }
    }
}
