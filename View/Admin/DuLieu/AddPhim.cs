//using pbl3.DAO;
using DoAn.BLL;
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

namespace DoAn.Admin.DuLieu
{
    public partial class AddPhim : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        string IDPhim { get; set; }
        //DataProvider data = new DataProvider();
        //PhimDAL phimDAO = new PhimDAL();
        public AddPhim(string id)
        {
            IDPhim = id;
            InitializeComponent();
            cboTheLoai.Items.AddRange(QLBLL.Instance.GetCBBTheLoai().ToArray());
            GUI();
        }
        public void GUI()
        {
            Phim a = QLBLL.Instance.GetPhimByIDPhim(IDPhim);
            if (a != null)
            {
                txtPhimMa.Enabled = false;
                txtPhimTen.Text = a.TenPhim;
                txtPhimMa.Text = a.IDPhim;
                txtPhimThoiLuong.Text = Convert.ToString(a.ThoiLuong);
                txtPhimNamSX.Text = Convert.ToString(a.NamSX);
                dtpPhimNgayKC.Value = Convert.ToDateTime(a.NgayKhoiChieu);
                dtpPhimNgayKT.Value = Convert.ToDateTime(a.NgayKetThuc);
                txtPhimSanXuat.Text = a.SanXuat;
                txtPhimDaoDien.Text = a.DaoDien;
                foreach (CBBTheLoai r in cboTheLoai.Items)
                {
                    if (r.value == a.IDTheLoai)
                    {
                        cboTheLoai.SelectedItem = r;
                    }
                }

            }
        }
        private void lblMovieGenre_Click(object sender, EventArgs e)
        {

        }   

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //void InsertMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, string idTheLoai)
        //{
        //    if (phimDAO.InsertMovie(id, name, length, startDate, endDate, productor, director, year, idTheLoai))
        //    {
        //        MessageBox.Show("Thêm phim thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm phim thất bại");
        //    }
        //}
        private void btnOk_Click(object sender, EventArgs e)
        {
            Phim phim = new Phim
            {
                IDPhim = txtPhimMa.Text,
                TenPhim = txtPhimTen.Text,
                ThoiLuong = Convert.ToDouble(txtPhimThoiLuong.Text),
                NgayKhoiChieu =  (dtpPhimNgayKC.Value),
                NgayKetThuc = (dtpPhimNgayKT.Value),
                SanXuat = txtPhimSanXuat.Text,
                NamSX = Convert.ToInt32(txtPhimNamSX.Text),
                DaoDien = txtPhimDaoDien.Text,
                IDTheLoai = ((CBBTheLoai)cboTheLoai.SelectedItem).value,
                
                
            };
            QLBLL.Instance.ExecuteDBPhim(phim);
            d();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
