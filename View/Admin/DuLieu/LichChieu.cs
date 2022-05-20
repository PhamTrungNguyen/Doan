//using pbl3.BLL;
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

namespace pbl3.Admin.DuLieu
{
    public partial class LichChieu : UserControl
    {
        //LichChieuBLL lichchieuBll = new LichChieuBLL();
        //DataProvider data = new DataProvider();
        //PhimBLL phimBLL = new PhimBLL();
        ////
        //public LichChieu()
        //{
        //    InitializeComponent();
        //    LoadPhongChieuAndDinhDang();
        //}
        //public void LoadPhongChieuAndDinhDang()
        //{
        //    string queryPhongChieu = "select * from PhongChieu";
        //    foreach (DataRow i in data.ExecuteQuery(queryPhongChieu).Rows)
        //    {
        //        cboLichChieuPhong.Items.Add(new CBBPhongChieu
        //        {
        //            value = i["IDPhongChieu"].ToString(),
        //            text = i["TenPhong"].ToString(),
        //        });
        //    }
        //    string queryMaDinhDang = "select * from DinhDangPhim";
        //    foreach (DataRow i in data.ExecuteQuery(queryMaDinhDang).Rows)
        //    {
        //        cboLichChieuMa.Items.Add(new CBBDinhDang
        //        {
        //            value = i["IDDinhDangPhim"].ToString(),
        //            text = i["IDPhim"].ToString(),
        //            text1 = i["IDLoaiManHinh"].ToString()
        //        });

        //    }
        //}
        //public void Reload()
        //{
        //    dataGridView1.DataSource = lichchieuBll.LoadLichChieu();
        //    dataGridView1.Columns[0].Width = 250;// The id column 
        //    dataGridView1.Columns[1].Width = 250;
        //    dataGridView1.Columns[2].Width = 250;
        //    dataGridView1.Columns[3].Width = 250;
        //    dataGridView1.Columns[4].Width = 250; // The abbrevation columln
        //}
        private void btnLichChieuXem_Click_1(object sender, EventArgs e)
        {
            //Reload();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 1)
            //{
            //    txtLichChieuMALC.Text = dataGridView1.SelectedRows[0].Cells["Mã lịch chiếu"].Value.ToString();
            //    string maIDLichChieuPhong = dataGridView1.SelectedRows[0].Cells["Mã phòng"].Value.ToString();
            //    foreach (CBBPhongChieu i in cboLichChieuPhong.Items)
            //    {
            //        if (i.value == maIDLichChieuPhong)
            //        {
            //            cboLichChieuPhong.SelectedItem = i;
            //        }
            //    }
            //    string maIDDinhDang = dataGridView1.SelectedRows[0].Cells["Mã định dạng"].Value.ToString();
            //    string maPhim = "";
            //    string maLoaiMH = "";
            //    foreach (CBBDinhDang i in cboLichChieuMa.Items)
            //    {
            //        if (i.value == maIDDinhDang)
            //        {
            //            cboLichChieuMa.SelectedItem = i;
            //            maPhim = i.text;
            //            maLoaiMH = i.text1;
            //            foreach (DataRow p in phimBLL.LoadMovie().Rows)
            //            {
            //                if (p["IDPhim"].ToString() == maPhim)
            //                {
            //                    txtLichChieuPhim.Text = p["TenPhim"].ToString();
            //                }
            //            }
            //            //foreach(DataRow p in loaiMHDAL.LoadLoaiMH().Rows)
            //            //{
            //            //    if(p["IDLoaiManHinh"].ToString() == maLoaiMH)
            //            //    {
            //            //        txtLichChieuManHinh.Text = p["TenManHinh"].ToString();
            //            //    }    
            //            //}    

            //        }
            //    }
            //    string slip = (dataGridView1.SelectedRows[0].Cells["Thời gian chiếu"].Value.ToString());
            //    string[] split = slip.Split(' ');
            //    dtmShowtimeDate.Value = Convert.ToDateTime(split[0].ToString());
            //    dtmShowtimeTime.Value = Convert.ToDateTime(split[1].ToString());
            //}

        }

        private void cboLichChieuMa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //string maDinhDang = ((CBBDinhDang)cboLichChieuMa.SelectedItem).value.ToString();
            //string maPhim = "";
            //string maLoaiMH = "";
            //foreach (CBBDinhDang i in cboLichChieuMa.Items)
            //{
            //    if (i.value == maDinhDang)
            //    {
            //        cboLichChieuMa.SelectedItem = i;
            //        maPhim = i.text;
            //        maLoaiMH = i.text1;
            //        foreach (DataRow p in phimBLL.LoadMovie().Rows)
            //        {
            //            if (p["IDPhim"].ToString() == maPhim)
            //            {
            //                txtLichChieuPhim.Text = p["TenPhim"].ToString();
            //            }
            //        }
            //        //foreach(DataRow p in loaiMHDAL.LoadLoaiMH().Rows)
            //        //{
            //        //    if(p["IDLoaiManHinh"].ToString() == maLoaiMH)
            //        //    {
            //        //        txtLichChieuManHinh.Text = p["TenManHinh"].ToString();
            //        //    }    
            //        //}    

            //    }
            //}
        }
    }
}