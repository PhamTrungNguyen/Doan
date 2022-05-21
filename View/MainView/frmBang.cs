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

namespace pbl3
{
    public partial class frmBang : Form
    {
        public frmBang()
        {
            InitializeComponent();
        }
        doanEntities db = new doanEntities();
        private void listView_Click(object sender, EventArgs e)
        {
            if (lsvLichChieu.SelectedItems.Count > 0)
            {
                frmPhongChieu frm = new frmPhongChieu();
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }
        public void  LoadPhimByNgayKC_KT(DateTime date)
        {
            //cbbPhim.Items.AddRange((QLBLL.Instance.GetPhimByNgayKC_KT(date)).ToArray());
            cbbPhim.Items.Clear();
            cbbPhim.Items.AddRange((QLBLL.Instance.GetPhimByNgayKC_KT(date)).ToArray()); 

        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            LoadPhimByNgayKC_KT(dtpThoiGian.Value);
            
        }

        private void cbbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhim.SelectedIndex != -1)
            {
                string tenPhim = cbbPhim.SelectedItem.ToString();
                lsvLichChieu.Items.Clear();
                var idPhim = from p in db.DinhDangPhims
                                where p.Phim.TenPhim == tenPhim
                                select p.IDPhim;
                //FormatMovie format = cboFormatFilm.SelectedItem as FormatMovie;
                var lc = from p in db.LichChieux
                                where p.DinhDangPhim.Phim.TenPhim == tenPhim & p.TrangThai == "1"
                                select new { p.PhongChieu.TenPhong, p.DinhDangPhim.Phim.TenPhim, p.ThoiGianChieu, p.TrangThai };
               foreach(var i in lc.ToList())
                {
                    ListViewItem lvi = new ListViewItem("");
                    lvi.SubItems.Add(i.TenPhong.ToString());
                    lvi.SubItems.Add(i.TenPhim.ToString());
                    lvi.SubItems.Add(i.ThoiGianChieu.ToString());
                    lvi.SubItems.Add(i.TrangThai.ToString());
                    lvi.Tag = lvi;
                    lsvLichChieu.Items.Add(lvi);
                }
            }
        }
    }
}
