//using pbl3.BLL;
//using pbl3.DAO;
using DoAn.BLL;
using DoAn.DTO;
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
        public LichChieu()
        {
            InitializeComponent();
            LoadPhongChieuAndDinhDang();
        }
        public void LoadPhongChieuAndDinhDang()
        {
            cboLichChieuMa.Items.AddRange(QLBLL.Instance.GetCBBDinhDang().ToArray());
            cboLichChieuPhong.Items.AddRange(QLBLL.Instance.GetCBBPhongChieu().ToArray());
        }
        public void Reload()
        {
            dataGridView1.DataSource = QLBLL.Instance.ShowLichChieu();
            dataGridView1.Columns[0].Width = 250;// The id column 
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 250; // The abbrevation columln
        }
        private void btnLichChieuXem_Click_1(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtLichChieuMALC.Text = dataGridView1.SelectedRows[0].Cells["IDLichChieu"].Value.ToString();
                string maIDLichChieuPhong = dataGridView1.SelectedRows[0].Cells["IDPhong"].Value.ToString();
                foreach (CBBPhongChieu i in cboLichChieuPhong.Items)
                {
                    if (i.value == maIDLichChieuPhong)
                    {
                        cboLichChieuPhong.SelectedItem = i;
                    }
                }
                string maIDDinhDang = dataGridView1.SelectedRows[0].Cells["IDDinhDang"].Value.ToString();
                string maPhim = "";
                string maLoaiMH = "";
                foreach (CBBDinhDang i in cboLichChieuMa.Items)
                {
                    if (i.value == maIDDinhDang)
                    {
                        cboLichChieuMa.SelectedItem = i;
                        maPhim = i.text;
                        maLoaiMH = i.text1;
                        foreach (PhimDTO p in QLBLL.Instance.ShowPhim())
                        {
                            if (p.idPhim == maPhim)
                            {
                                txtLichChieuPhim.Text = p.tenPhim.ToString();
                            }
                        }
                        foreach (LoaiManHinhDTO p in QLBLL.Instance.ShowLMH())
                        {
                            if (p.ID_LoaiManHinh.ToString() == maLoaiMH)
                            {
                                txtLichChieuManHinh.Text = p.TenManHinh.ToString();
                            }
                        }

                    }
                }
                string slip = (dataGridView1.SelectedRows[0].Cells["ThoiGianChieu"].Value.ToString());
                string[] split = slip.Split(' ');
                dtmShowtimeDate.Value = Convert.ToDateTime(split[0].ToString());
                dtmShowtimeTime.Value = Convert.ToDateTime(split[1].ToString());
            }

        }

        private void cboLichChieuMa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string maDinhDang = ((CBBDinhDang)cboLichChieuMa.SelectedItem).value.ToString();
            string maPhim = "";
            string maLoaiMH = "";
            foreach (CBBDinhDang i in cboLichChieuMa.Items)
            {
                if (i.value == maDinhDang)
                {
                    cboLichChieuMa.SelectedItem = i;
                    maPhim = i.text;
                    maLoaiMH = i.text1;
                    foreach (PhimDTO p in QLBLL.Instance.ShowPhim())
                    {
                        if (p.idPhim.ToString() == maPhim)
                        {
                            txtLichChieuPhim.Text = p.tenPhim.ToString();
                        }
                    }
                    foreach (LoaiManHinhDTO p in QLBLL.Instance.ShowLMH())
                    {
                        if (p.ID_LoaiManHinh.ToString() == maLoaiMH)
                        {
                            txtLichChieuManHinh.Text = p.TenManHinh.ToString();
                        }
                    }

                }
            }
        }
    }
}