//using pbl3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.BLL;
//using pbl3.DAL;
//using pbl3.DAO;
using pbl3.DTO;
using pbl3.View.Admin.DuLieu;

namespace pbl3.Admin.DuLieu
{
    public partial class DinhDang : UserControl
    {
        //DinhDangPhimBLL dinhDangPhimBLL = new DinhDangPhimBLL();
        //DataProvider data = new DataProvider();
        public DinhDang()
        {
            InitializeComponent();
            LoadLoaiManHinhANDPhim();


        }
        public void LoadLoaiManHinhANDPhim()
        {
            //string queryLoaiManHinh = "select * from LoaiManHinh";
            //foreach (DataRow i in data.ExecuteQuery(queryLoaiManHinh).Rows)
            //{
            //    cbbDinhDangMaMH.Items.Add(new CBBLoaiManHinh
            //    {
            //        value = i["IDLoaiManHinh"].ToString(),
            //        text = i["TenManHinh"].ToString(),
            //    });
            //}
            cbbDinhDangMaPhim.Items.AddRange(QLBLL.Instance.GetCBBPhim().ToArray());
            cbbDinhDangMaMH.Items.AddRange(QLBLL.Instance.GetCBBLoaiManHinh().ToArray());
        }
        public void Reload()
        {
            dgvDinhDangPhim.DataSource = QLBLL.Instance.ShowDinhDangPhim();
            dgvDinhDangPhim.Columns[0].Width = 250;// The id column 
            dgvDinhDangPhim.Columns[1].Width = 250;// The abbrevation columln
            dgvDinhDangPhim.Columns[2].Width = 250;// The abbrevation columln

        }
        private void btnDinhDangXem_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void btnDinhDangThem_Click(object sender, EventArgs e)
        {

            AddDinhDang addDinhDang = new AddDinhDang("");
            addDinhDang.d = new AddDinhDang.Mydel(Reload);
            addDinhDang.Show();
        }
        private void btnDinhDangSua_Click(object sender, EventArgs e)
        {
            if (dgvDinhDangPhim.SelectedRows.Count == 1)
            {
                string IDPhim = dgvDinhDangPhim.SelectedRows[0].Cells["ID_DinhDangPhim"].Value.ToString();
                AddDinhDang addDinhDang = new AddDinhDang(IDPhim);
                addDinhDang.Show();
                addDinhDang.d = new AddDinhDang.Mydel(Reload);
            }
        }
      

        private void dgvDinhDangPhim_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDinhDangPhim.SelectedRows.Count == 1)
            {
                txtDinhDangMaDinhDang.Text = dgvDinhDangPhim.SelectedRows[0].Cells["ID_DinhDangPhim"].Value.ToString();
                string maManHinh = dgvDinhDangPhim.SelectedRows[0].Cells["ID_LoaiManHinh"].Value.ToString();
                foreach (CBBLoaiManHinh i in cbbDinhDangMaMH.Items)
                {
                    if (i.value == maManHinh)
                    {
                        cbbDinhDangMaMH.SelectedItem = i;
                        txtDinhDangTenMH.Text = i.text;
                    }
                }
                string maPhim = dgvDinhDangPhim.SelectedRows[0].Cells["ID_Phim"].Value.ToString();
                foreach (CBBPhim i in cbbDinhDangMaPhim.Items)
                {
                    if (i.value == maPhim)
                    {
                        cbbDinhDangMaPhim.SelectedItem = i;
                        txtDinhDangTenPhim.Text = i.text;
                    }
                }
            }

        }

        private void cbbDinhDangMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maManHinh = ((CBBLoaiManHinh)cbbDinhDangMaMH.SelectedItem).value.ToString();
            foreach (CBBLoaiManHinh i in cbbDinhDangMaMH.Items)
            {
                if (i.value == maManHinh)
                {
                    txtDinhDangTenMH.Text = i.text;
                }
            }
        }

        private void cbbDinhDangMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhim = ((CBBPhim)cbbDinhDangMaPhim.SelectedItem).value.ToString();
            foreach (CBBPhim i in cbbDinhDangMaPhim.Items)
            {
                if (i.value == maPhim)
                {
                    txtDinhDangTenPhim.Text = i.text;
                }
            }
        }

        private void btnDinhDangXoa_Click(object sender, EventArgs e)
        {
            if (dgvDinhDangPhim.SelectedRows.Count == 1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    string ID_DinhDangPhim = dgvDinhDangPhim.SelectedRows[0].Cells["ID_DinhDangPhim"].Value.ToString();
                    QLBLL.Instance.DelDinhDangPhim(ID_DinhDangPhim);
                    Reload();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn để xóa");
            }
        }
    }


}
