//using pbl3.BLL;
using DoAn.BLL;
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

namespace pbl3.Admin.DuLieu
{
    public partial class LoaiManHinh : UserControl
    {
        public LoaiManHinh()
        {
            InitializeComponent();
        }
        //LoaiMHBLL loaiMHBLL = new LoaiMHBLL();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void Reload()
        {
            dgvManHinh.DataSource = QLBLL.Instance.ShowLMH();
        }
        private void BtnManHinhXem_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void BtnManHinhThem_Click(object sender, EventArgs e)
        {
            AddLoaiMH addLoaiMH = new AddLoaiMH("");
            addLoaiMH.d = new AddLoaiMH.Mydel(Reload);
            addLoaiMH.Show();
        }

        private void BtnManHinhSua_Click(object sender, EventArgs e)
        {
            if (dgvManHinh.SelectedRows.Count == 1)
            {
                string IDLoaiMH = dgvManHinh.SelectedRows[0].Cells["ID_LoaiManHinh"].Value.ToString();
                AddLoaiMH addlmh = new AddLoaiMH(IDLoaiMH);
                addlmh.Show();
                addlmh.d = new AddLoaiMH.Mydel(Reload);
            }
        }

        private void BtnManHinhXoa_Click(object sender, EventArgs e)
        {
            if (dgvManHinh.SelectedRows.Count == 1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    string maLMH = dgvManHinh.SelectedRows[0].Cells["ID_LoaiManHinh"].Value.ToString();
                    QLBLL.Instance.DelLoaiMH(maLMH);
                    Reload();
                }
            }
        }

        private void dgvManHinh_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvManHinh.SelectedRows.Count == 1)
            {
                txtManHinhMa.Enabled = false;
                txtManHinhMa.Text = dgvManHinh.SelectedRows[0].Cells["ID_LoaiManHinh"].Value.ToString();
                txttxtManHinhTen.Text = dgvManHinh.SelectedRows[0].Cells["TenManHinh"].Value.ToString();
            }
        }
    }
}
