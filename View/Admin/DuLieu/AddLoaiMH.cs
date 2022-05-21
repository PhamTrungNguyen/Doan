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
    public partial class AddLoaiMH : Form
    {
        public delegate void Mydel();
        public Mydel d;
        string IDLoaiMH { get; set; }
        //LoaiMHDAL loaiMHDAL = new LoaiMHDAL();
        public AddLoaiMH(string id)
        {
            InitializeComponent();
            IDLoaiMH = id;
            GUI();
        }
        public void GUI()
        {
            LoaiManHinh a = QLBLL.Instance.GetLMHByIDLMH(IDLoaiMH);
            if (a != null)
            {
                txtMaLoaiMH.Enabled = false;
                txtMaLoaiMH.Text = a.IDLoaiManHinh;
                txtTenLoaiMH.Text = a.TenManHinh;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            LoaiManHinh lmh = new LoaiManHinh
            {
                IDLoaiManHinh = txtMaLoaiMH.Text,
                TenManHinh = txtTenLoaiMH.Text,
            };
            QLBLL.Instance.ExecuteDBLoaiMH(lmh);
            d();
            this.Close();
        }
        //private void InsertLoaiMH(string IDLoaiMH, string TenLoaiMH)
        //{
        //    if (loaiMHDAL.ThemLoaiMH(IDLoaiMH, TenLoaiMH))
        //    {
        //        MessageBox.Show("Thêm thể loại thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm thể loại thất bại");
        //    }
        //}
    }
}
