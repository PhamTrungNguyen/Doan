//using pbl3.DAL;
//using pbl3.DAO;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.View.Admin.DuLieu
{
    public partial class AddDinhDang : Form
    {
        //public delegate void Mydel();
        //public Mydel d { get; set; }
        //DataProvider data = new DataProvider();
        //DinhDangPhimDAL dinhDangPhimDAL = new DinhDangPhimDAL();
        public AddDinhDang()
        {
            InitializeComponent();
            //Load();
        }
        //public void Load()
        //{
        //    string queryLoaiManHinh = "select * from LoaiManHinh";
        //    foreach (DataRow i in data.ExecuteQuery(queryLoaiManHinh).Rows)
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
        //void InsertDinhDangPhim(string idDinhDangPhim , string idPhim,  string idLoaiManHinh)
        //{
        //    if (dinhDangPhimDAL.ThemDinhDang(idDinhDangPhim, idPhim, idLoaiManHinh))
        //    {
        //        MessageBox.Show("Thêm phim thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm phim thất bại");
        //    }
        //}
        private void btnDinhDangOk_Click(object sender, EventArgs e)
        {
            //string idDinhDangPhim = txtDinhDangMaDinhDang.Text;
            //string idPhim = ((CBBPhim)cbbDinhDangMaPhim.SelectedItem).value;
            //string idLoaiManHinh = ((CBBLoaiManHinh)cbbDinhDangMaMH.SelectedItem).value;
            //InsertDinhDangPhim(idDinhDangPhim,idPhim,idLoaiManHinh);
            //d();
            //this.Close();
        }


        private void cbbDinhDangMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string maPhim = ((CBBPhim)cbbDinhDangMaPhim.SelectedItem).value.ToString();
            //foreach (CBBPhim i in cbbDinhDangMaPhim.Items)
            //{
            //    if (i.value == maPhim)
            //    {
            //        txtDinhDangTenPhim.Text = i.text;
            //    }
            //}
        }

        private void cbbDinhDangMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string maManHinh = ((CBBLoaiManHinh)cbbDinhDangMaMH.SelectedItem).value.ToString();
            //foreach (CBBLoaiManHinh i in cbbDinhDangMaMH.Items)
            //{
            //    if (i.value == maManHinh)
            //    {
            //        txtDinhDangTenMH.Text = i.text;
            //    }
            //}
        }
    }
}
