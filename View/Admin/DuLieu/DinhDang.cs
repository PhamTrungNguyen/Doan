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
            //LoadLoaiManHinhANDPhim();


        }
        //public void LoadLoaiManHinhANDPhim()
        //{
        //    string queryLoaiManHinh = "select * from LoaiManHinh";
        //    foreach(DataRow i in data.ExecuteQuery(queryLoaiManHinh).Rows)
        //    {
        //        cbbDinhDangMaMH.Items.Add(new CBBLoaiManHinh
        //        {
        //            value = i["IDLoaiManHinh"].ToString(),
        //            text = i["TenManHinh"].ToString(),
        //        });
        //    }
        //    string queryPhim = "select * from Phim";
        //    foreach (DataRow i in data.ExecuteQuery(queryPhim).Rows)
        //    {
        //        cbbDinhDangMaPhim.Items.Add(new CBBPhim
        //        {
        //            value = i["IDPhim"].ToString(),
        //            text = i["TenPhim"].ToString(),
        //        });
        //    }
        //}
        //public void Reload()
        //{
        //    dgvDinhDangPhim.DataSource = dinhDangPhimBLL.LoadDinhDangPhim();
        //    dgvDinhDangPhim.Columns[0].Width = 250;// The id column 
        //    dgvDinhDangPhim.Columns[1].Width = 250;// The abbrevation columln
        //}
        private void btnDinhDangXem_Click(object sender, EventArgs e)
        {
            //Reload();
        }
        private void btnDinhDangSua_Click(object sender, EventArgs e)
        {
            //string idManHinh = cbbDinhDangMaMH.SelectedItem.ToString();
            //string idPhim = cbbDinhDangMaPhim.SelectedItem.ToString();
            //string idDinhDang = txtDinhDangMaDinhDang.Text;
            //dinhDangPhimBLL.UpdateDinhDangPhim(idManHinh, idPhim, idDinhDang);
            //Reload();
        }
        private void btnDinhDangThem_Click(object sender, EventArgs e)
        {
            //AddDinhDang addDinhDang = new AddDinhDang();
            //addDinhDang.d = new AddDinhDang.Mydel(Reload);
            //addDinhDang.Show();
        }
        private void dgvDinhDangPhim_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if(dgvDinhDangPhim.SelectedRows.Count ==1)
            //{
            //    txtDinhDangMaDinhDang.Text = dgvDinhDangPhim.SelectedRows[0].Cells["Mã Định Dạng Phim"].Value.ToString();
            //    string maManHinh = dgvDinhDangPhim.SelectedRows[0].Cells["Mã Loại Màn Hình"].Value.ToString();
            //    foreach(CBBLoaiManHinh i in cbbDinhDangMaMH.Items)
            //    {
            //        if(i.value == maManHinh)
            //        {
            //            cbbDinhDangMaMH.SelectedItem = i;
            //            txtDinhDangTenMH.Text = i.text;
            //        }    
            //    }
            //    string maPhim = dgvDinhDangPhim.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
            //    foreach (CBBPhim i in cbbDinhDangMaPhim.Items)
            //    {
            //        if (i.value == maPhim)
            //        {
            //            cbbDinhDangMaPhim.SelectedItem = i;
            //            txtDinhDangTenPhim.Text = i.text;
            //        }
            //    }
        }
    }
        //private void cbbDinhDangMaMH_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //string maManHinh = ((CBBLoaiManHinh)cbbDinhDangMaMH.SelectedItem).value.ToString();
        //    //foreach (CBBLoaiManHinh i in cbbDinhDangMaMH.Items)
        //    //{
        //    //    if (i.value == maManHinh)
        //    //    {
        //    //        txtDinhDangTenMH.Text = i.text;
        //    //    }
        //    //}
        //}

        //private void cbbDinhDangMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //string maPhim = ((CBBPhim)cbbDinhDangMaPhim.SelectedItem).value.ToString();
        //    //foreach (CBBPhim i in cbbDinhDangMaPhim.Items)
        //    //{
        //    //    if (i.value == maPhim)
        //    //    {
        //    //        txtDinhDangTenPhim.Text = i.text;
        //    //    }
        //    //}
        //}

    
    
}
