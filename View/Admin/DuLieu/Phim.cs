
//using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Admin.DuLieu;
using DoAn.BLL;
using pbl3.DTO;
//using pbl3.BLL;

namespace pbl3.Admin.DuLieu
{
    public partial class Phim : UserControl
    {
        //DataProvider data = new DataProvider();
        //PhimBLL phimBLL = new PhimBLL();
        //CBBTheLoai cbbTheLoai = new CBBTheLoai();
        public Phim()
        {
            InitializeComponent();
            Loadtheloai();
        }
        public void Loadtheloai()
        {
            cboTheLoai.Items.AddRange(QLBLL.Instance.GetCBBTheLoai().ToArray());
        }
        public void Reload()
        {
            dgvMovie.DataSource = QLBLL.Instance.ShowPhim();
        }
        private void btnPhimXem_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void btnPhimThem_Click(object sender, EventArgs e)
        {

            AddPhim addphim = new AddPhim("");
            addphim.Show();
            addphim.d = new AddPhim.Mydel(Reload);

        }
        private void btnPhimUpdate_Click(object sender, EventArgs e)
        {
            if(dgvMovie.SelectedRows.Count == 1)
            {
                string IDPhim = dgvMovie.SelectedRows[0].Cells["idPhim"].Value.ToString();
                AddPhim addphim = new AddPhim(IDPhim);
                addphim.Show();
                addphim.d = new AddPhim.Mydel(Reload);
            }
                
        }
        private void btnPhimXoa_Click(object sender, EventArgs e)
        {
            if (dgvMovie.SelectedRows.Count == 1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    string maPhim = dgvMovie.SelectedRows[0].Cells["IDPhim"].Value.ToString();
                     QLBLL.Instance.DelPhim(maPhim);
                     Reload();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn để xóa");
            }
        }

        private void dgvMovie_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMovie.SelectedRows.Count == 1)
            {
                txtPhimMa.Enabled = false;
                txtPhimMa.Text = dgvMovie.SelectedRows[0].Cells["IDPhim"].Value.ToString();
                txtPhimTen.Text = dgvMovie.SelectedRows[0].Cells["TenPhim"].Value.ToString();
                txtPhimThoiLuong.Text = dgvMovie.SelectedRows[0].Cells["ThoiLuong"].Value.ToString();
                txtPhimNamSX.Text = dgvMovie.SelectedRows[0].Cells["NamSanXuat"].Value.ToString();
                dtpPhimNgayKC.Value = Convert.ToDateTime(dgvMovie.SelectedRows[0].Cells["ngayKC"].Value.ToString());
                dtpPhimNgayKT.Value = Convert.ToDateTime(dgvMovie.SelectedRows[0].Cells["ngayKT"].Value.ToString());
                txtPhimSanXuat.Text = dgvMovie.SelectedRows[0].Cells["SanXuat"].Value.ToString();
                txtPhimDaoDien.Text = dgvMovie.SelectedRows[0].Cells["DaoDien"].Value.ToString();
                string id = dgvMovie.SelectedRows[0].Cells["IDTheLoai"].Value.ToString();
                foreach (CBBTheLoai r in cboTheLoai.Items)
                {
                    if (r.value == id)
                    {
                        cboTheLoai.SelectedItem = r;
                    }
                }
            }
        }

    }


}
