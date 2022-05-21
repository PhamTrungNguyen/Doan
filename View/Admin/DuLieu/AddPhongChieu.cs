//using pbl3.DAL;
//using pbl3.DAO;
using DoAn;
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

namespace pbl3.View.Admin.DuLieu
{
    public partial class AddPhongChieu : Form
    {
        public delegate void Mydel();
        public Mydel d;
        public string IDPhongChieu { get; set; }

        public AddPhongChieu(string id)
        {
            InitializeComponent();
            IDPhongChieu = id;
            cbbManHinh.Items.AddRange(QLBLL.Instance.GetCBBLoaiMH().ToArray());
            GUI();
        }
        public void GUI()
        {
            PhongChieu a = QLBLL.Instance.GetPCByIDPC(IDPhongChieu);
            if (a != null)
            {
                txtIDPhongChieu.Enabled = false;
                txtIDPhongChieu.Text = a.IDPhongChieu;
                txtTenPhong.Text = a.TenPhong;
                txtSoChoNgoi.Text = Convert.ToString(a.SoChoNgoi);
                txtTinhTrang.Text = a.TinhTrang;
                txtSoHangGhe.Text = Convert.ToString(a.SoHangGhe);
                txtSoGhe1Hang.Text = Convert.ToString(a.SoGheMotHang);
                foreach (CBBLoaiManHinh r in cbbManHinh.Items)
                {
                    if (r.value == a.IDManHinh)
                    {
                        cbbManHinh.SelectedItem = r;
                    }
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PhongChieu pc = new PhongChieu
            {
                IDPhongChieu = txtIDPhongChieu.Text,
                TenPhong = txtTenPhong.Text,
                IDManHinh = ((CBBLoaiManHinh)cbbManHinh.SelectedItem).value,
                SoChoNgoi = Convert.ToInt32(txtSoChoNgoi.Text),
                TinhTrang = txtTinhTrang.Text,
                SoHangGhe = Convert.ToInt32(txtSoHangGhe.Text),
                SoGheMotHang = Convert.ToInt32(txtSoGhe1Hang.Text),
            };
            QLBLL.Instance.ExecuteDBPhongChieu(pc);
            d();
            this.Close();
        }
        //private void InsertPhongChieu(string IDPhongChieu, string TenPhongChieu, string IDManHinh, int SoChoNgoi, string TinhTrang, int SoHangGhe, int SoGheMotHang)
        //{
        //    if (phongchieuDAL.ThemPhongChieu(IDPhongChieu, TenPhongChieu, IDManHinh, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang))
        //    {
        //        MessageBox.Show("Thêm phòng chiếu thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm phòng chiếu thất bại");
        //    }
        //}
    }
}
