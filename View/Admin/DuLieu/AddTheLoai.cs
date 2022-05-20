using DoAn.BLL;
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
    public partial class AddTheLoai : Form
    {
        public delegate void Mydel();
        public Mydel d;
        public string IDTheLoai { get; set; }
        public AddTheLoai(string id)
        {
            IDTheLoai = id;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            TheLoai tl = QLBLL.Instance.GetTheLoaiByIDTheLoai(IDTheLoai);
            if(tl != null)
            {
                txtTheLoaiMa.Enabled = false;
                txtTheLoaiMa.Text = tl.IDTheLoai;
                txtTheLoaiTen.Text = tl.TenTheLoai;
            }
        }
        private void btnTheLoaiOK_Click(object sender, EventArgs e)
        {
            //string maTheLoai = txtTheLoaiMa.Text;
            //string tenTheLoai = txtTheLoaiTen.Text;
            //InsertTheLoai(maTheLoai, tenTheLoai);
            TheLoai theLoai = new TheLoai()
            {
                IDTheLoai = txtTheLoaiMa.Text,
                TenTheLoai = txtTheLoaiTen.Text,
            };
            QLBLL.Instance.ExecuteDBTheLoai(theLoai);
            d();
            this.Close();
        }
        //private void InsertTheLoai(string idTheLoai, string tenTheLoai)
        //{
        //    if(theLoaiDao.ThemTheLoai(idTheLoai,tenTheLoai))
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
