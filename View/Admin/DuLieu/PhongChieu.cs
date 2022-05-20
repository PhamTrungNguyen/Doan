//using pbl3.BLL;
//using pbl3.DAO;
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

namespace pbl3.Admin.DuLieu
{
    public partial class PhongChieu : UserControl
    {
        //PhongChieuBLL phongchieuBLL = new PhongChieuBLL();
        //public PhongChieu()
        //{
        //    InitializeComponent();
        //    string query = "select * from LoaiManHinh"; 
        //    DataProvider data = new DataProvider();
        //    foreach (DataRow i in data.ExecuteQuery(query).Rows)
        //    {
        //        cbbManHinh.Items.Add(new CBBLoaiManHinh
        //        {
        //            value = i["IDLoaiManHinh"].ToString(),
        //            text = i["TenManHinh"].ToString()
        //        });
        //    }
        //}
        //public void Reload()
        //{
        //    dgvPhongChieu.DataSource = phongchieuBLL.LoadPhongChieu();
        //}
        private void btnPhongChieuThemXem_Click(object sender, EventArgs e)
        {
            //Reload();
        }

        private void btnPhongChieuThem_Click(object sender, EventArgs e)
        {
            //AddPhongChieu addPhongChieu = new AddPhongChieu();
            //addPhongChieu.d = new AddPhongChieu.Mydel(Reload);
            //addPhongChieu.Show();
        }

        private void btnPhongChieuThemSua_Click(object sender, EventArgs e)
        {
            //string IDPhongChieu = txtPhongChieuMaPhong.Text;
            //string TenPhong = txtPhongChieuTenPhong.Text;
            //int SoChoNgoi = Convert.ToInt32(txtPhongChieuChoNgoi.Text);
            //string TinhTrang = txtPhongChieuTinhTrang.Text;
            //int SoHangGhe = Convert.ToInt32(txtPhongChieuSoHangGhe.Text);
            //int SoGhe1Hang = Convert.ToInt32(txtPhongChieuGheMoiHang.Text);
            //string IDLoaiMH = ((CBBLoaiManHinh)cbbManHinh.SelectedItem).value;
            //phongchieuBLL.UpdatePhongChieu(IDPhongChieu, TenPhong, IDLoaiMH, SoChoNgoi, TinhTrang, SoHangGhe, SoGhe1Hang);
            //Reload();
        }

        private void dgvPhongChieu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dgvPhongChieu.SelectedRows.Count == 1)
            //{
            //    txtPhongChieuMaPhong.Enabled = false;
            //    txtPhongChieuMaPhong.Text = dgvPhongChieu.SelectedRows[0].Cells["Mã phòng chiếu"].Value.ToString();
            //    txtPhongChieuTenPhong.Text = dgvPhongChieu.SelectedRows[0].Cells["Tên phòng"].Value.ToString();
            //    txtPhongChieuChoNgoi.Text = dgvPhongChieu.SelectedRows[0].Cells["Số chỗ ngồi"].Value.ToString();
            //    txtPhongChieuTinhTrang.Text = dgvPhongChieu.SelectedRows[0].Cells["Tình trạng"].Value.ToString();
            //    txtPhongChieuSoHangGhe.Text = dgvPhongChieu.SelectedRows[0].Cells["Số hàng ghế"].Value.ToString();
            //    txtPhongChieuGheMoiHang.Text = dgvPhongChieu.SelectedRows[0].Cells["Số ghế một hàng"].Value.ToString();
            //    string id = dgvPhongChieu.SelectedRows[0].Cells["Mã màn hình"].Value.ToString();
            //    foreach (CBBLoaiManHinh i in cbbManHinh.Items)
            //    {
            //        if (i.value == id)
            //        {
            //            cbbManHinh.SelectedItem = i;
            //        }
            //    }

            //}
        }
    }
}
