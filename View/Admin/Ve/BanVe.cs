using DoAn.BLL;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.View.Admin.Ve
{
    public partial class BanVe : UserControl
    {
        public BanVe()
        {
            InitializeComponent();
        }
        doanEntities db = new doanEntities();
        public void LoadAllListLichChieu()
        {
            lsvLichChieu.Items.Clear();
            List<LichChieuDTO> allListShowTime = QLBLL.Instance.GetAllListShowTimes();
            foreach (LichChieuDTO showTimes in allListShowTime)
            {
                //MessageBox.Show(showTimes.IDPhong.ToString());
                ListViewItem lvi = new ListViewItem(showTimes.IDPhong);
                lvi.SubItems.Add(showTimes.TenPhim);
                lvi.SubItems.Add(showTimes.ThoiGianChieu.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.TrangThai == "1")
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                lsvLichChieu.Items.Add(lvi);
            }
            //var listLichChieu = db.LichChieux.Select(p =>
            //  new { p.PhongChieu.TenPhong, p.DinhDangPhim.Phim.TenPhim, p.ThoiGianChieu, p.TrangThai });

            //lsvLichChieu.Items.Clear();
            //try
            //{

            //foreach (var i in listLichChieu.ToList())
            //{
            //        ListViewItem lvi = new ListViewItem(i.TenPhong);
            //        lvi.SubItems.Add(i.TenPhim);
            //        lvi.SubItems.Add(i.ThoiGianChieu.ToString());
            //        lvi.Tag = i;

            //        if (i.TrangThai == "1")
            //        {
            //            lvi.SubItems.Add("Đã tạo");
            //        }
            //        else
            //        {
            //            lvi.SubItems.Add("Chưa Tạo");
            //        }
            //        lsvLichChieu.Items.Add(lvi);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void LoadListShowTimesNotCreateTickets()
        {
            lsvLichChieu.Items.Clear();

            List<LichChieuDTO> allListShowTime = QLBLL.Instance.GetListShowTimesNotCreateTickets();
            foreach (LichChieuDTO showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.IDPhong);
                lvi.SubItems.Add(showTimes.TenPhim);
                lvi.SubItems.Add(showTimes.ThoiGianChieu.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.TrangThai == "1")
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                lsvLichChieu.Items.Add(lvi);
            }
        }
        private void dtgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void btnAllListShowTimes_Click(object sender, EventArgs e)
        {
            LoadAllListLichChieu();
        }
        //public static List<BanVeDTO> GetListTicketsByShowTimes(string showTimesID)
        //{
        //    List<BanVeDTO> listTicket = new List<BanVeDTO>();
        //    string query = "select * from Ve where idLichChieu = '" + showTimesID + "'";
        //    DataTable data = Data.ExecuteQuery(query);
        //    foreach (DataRow row in data.Rows)
        //    {
        //        BanVeDTO ticket = new BanVeDTO(row);
        //        listTicket.Add(ticket);
        //    }
        //    return listTicket;
        //}
        //public void LoadVe(string idLichChieu)
        //{

        //    List<BanVeDTO> listTicket = GetListTicketsByShowTimes(idLichChieu);
        //    dtgvTicket.DataSource = listTicket;
        //}
        private void btnAddTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvLichChieu.SelectedItems.Count == 1)
            {
                LichChieuDTO lichchieu = lsvLichChieu.SelectedItems[0].Tag as LichChieuDTO;
                //MessageBox.Show(lichchieu.TrangThai);

                //if (Convert.ToInt32(lichchieu.TrangThai) == 1)
                //{
                //    MessageBox.Show("LỊCH CHIẾU NÀY ĐÃ ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                //    return;
                //}
                QLBLL.Instance.AutoCreateTicketsByShowTimes(lichchieu);
                LoadAllListLichChieu();
                //LoadVe(lichchieu.IDLichChieu);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ TẠO!!!", "THÔNG BÁO");
            }
        }

        private void panel61_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvLichChieu.SelectedItems.Count > 0)
            {
                LichChieuDTO showTimes = lsvLichChieu.SelectedItems[0].Tag as LichChieuDTO;
                if (showTimes.TrangThai == "0")
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY CHƯA ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                QLBLL.Instance.DeleteTicketsByShowTimes(showTimes);
                LoadAllListLichChieu();
                //LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XÓA!!!", "THÔNG BÁO");
            }
        }

        private void btnShowShowTimeNotCreateTickets_Click(object sender, EventArgs e)
        {
            LoadListShowTimesNotCreateTickets();
        }
    }
}
