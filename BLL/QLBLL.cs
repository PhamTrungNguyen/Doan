using DoAn.DTO;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.BLL
{
    public class QLBLL
    {
        doanEntities db = new doanEntities();
        private static QLBLL _Instance;
        public static QLBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLBLL();
                }
                return _Instance;
            }
            private set { }
        }
        //---------------------------- Phim ----------------------------

        public List<PhimDTO> ShowPhim()
        {
            List<PhimDTO> dataphim = new List<PhimDTO>();
            dataphim = (from p in db.Phims
                        select
                new PhimDTO
                {
                    idPhim = p.IDPhim,
                    tenPhim = p.TenPhim,
                    thoiLuong = (double)p.ThoiLuong,
                    ngayKC = (DateTime)p.NgayKhoiChieu,
                    ngayKT = (DateTime)p.NgayKetThuc,
                    sanXuat = p.SanXuat,
                    namSanXuat = (int)p.NamSX,
                    daoDien = p.DaoDien,
                    idTheLoai = p.IDTheLoai,
                }).ToList();
            return dataphim;
        }
        public void DelPhim(string IDPhim)
        {
            foreach (DinhDangPhim i in db.DinhDangPhims)
            {
                if (i.IDPhim == IDPhim)
                {
                    db.DinhDangPhims.Remove(i);
                }
            }
            Phim p = db.Phims.Find(IDPhim);
            db.Phims.Remove(p);
            db.SaveChanges();
        }
        public void ExecuteDBPhim(Phim phim)
        {
            Phim p = db.Phims.Find(phim.IDPhim);
            if (p != null)
            {
                p.IDPhim = phim.IDPhim;
                p.TenPhim = phim.TenPhim;
                p.ThoiLuong = Convert.ToDouble(phim.ThoiLuong);
                p.NgayKhoiChieu = Convert.ToDateTime(phim.NgayKhoiChieu);
                p.NgayKetThuc = Convert.ToDateTime(phim.NgayKetThuc);
                p.SanXuat = phim.SanXuat;
                p.NamSX = Convert.ToInt32(phim.NamSX);
                p.DaoDien = phim.DaoDien;
                p.IDTheLoai = phim.IDTheLoai;

            }
            else
            {
                db.Phims.Add(phim);
            }
            db.SaveChanges();
        }
        public Phim GetPhimByIDPhim(string IDPhim)
        {
            return db.Phims.Find(IDPhim);
        }
        //---------------------------- TheLoai ----------------------------

        public List<TheLoaiDTO> ShowTheLoai()
        {
            List<TheLoaiDTO> datatheloai = new List<TheLoaiDTO>();
            datatheloai = (from p in db.TheLoais
                           select
                   new TheLoaiDTO
                   {
                       ID_TheLoai = p.IDTheLoai,
                       TenTheLoai = p.TenTheLoai,
                   }).ToList();
            return datatheloai;
        }
        public void DelTheLoai(string IDTheLoai)
        {
            foreach (Phim i in db.Phims)
            {

                if (i.IDTheLoai == IDTheLoai)
                {
                    db.Phims.Remove(i);

                }
            }
            TheLoai tl = db.TheLoais.Find(IDTheLoai);
            db.TheLoais.Remove(tl);
            db.SaveChanges();
        }
        public void ExecuteDBTheLoai(TheLoai tl)
        {
            TheLoai theloai = db.TheLoais.Find(tl.IDTheLoai);
            if (theloai != null)
            {
                theloai.IDTheLoai = tl.IDTheLoai;
                theloai.TenTheLoai = tl.TenTheLoai;

            }
            else
            {
                db.TheLoais.Add(tl);
            }
            db.SaveChanges();
        }
        public List<CBBTheLoai> GetCBBTheLoai()
        {
            List<CBBTheLoai> data = new List<CBBTheLoai>();
            foreach (TheLoai i in db.TheLoais)
            {
                data.Add(new CBBTheLoai
                {
                    value = i.IDTheLoai,
                    text = i.TenTheLoai,
                });
            }
            return data;
        }
        public TheLoai GetTheLoaiByIDTheLoai(string IDTheLoai)
        {
            return db.TheLoais.Find(IDTheLoai);
        }
        //---------------------------- DinhDangPhim ----------------------------
        public List<DinhDangPhimDTO> ShowDinhDangPhim()
        {
            List<DinhDangPhimDTO> dataDinhDangPhim = new List<DinhDangPhimDTO>();
            dataDinhDangPhim = (from p in db.DinhDangPhims
                                select
                        new DinhDangPhimDTO
                        {
                            ID_DinhDangPhim = p.IDDinhDangPhim,
                            ID_Phim = p.IDPhim,
                            ID_LoaiManHinh = p.IDLoaiManHinh,
                        }).ToList();
            return dataDinhDangPhim;
        }
        public void ExecuteDBDinhDangPhim(DinhDangPhim ddpim)
        {
            DinhDangPhim dinhDangPhim = db.DinhDangPhims.Find(ddpim.IDDinhDangPhim);
            if (dinhDangPhim != null)
            {
                dinhDangPhim.IDDinhDangPhim = ddpim.IDDinhDangPhim;
                dinhDangPhim.IDPhim = ddpim.IDPhim;
                dinhDangPhim.IDLoaiManHinh = ddpim.IDLoaiManHinh;

            }
            else
            {
                db.DinhDangPhims.Add(ddpim);
            }
            db.SaveChanges();
        }
        public void DelDinhDangPhim(string IDDinhDangPhim)
        {
            DinhDangPhim ddphim = db.DinhDangPhims.Find(IDDinhDangPhim);
            foreach (LichChieu i in db.LichChieux)
            {
                if (i.IDDinhDang == IDDinhDangPhim)
                {
                    db.LichChieux.Remove(i);
                }
            }
            db.DinhDangPhims.Remove(ddphim);
            db.SaveChanges();
        }
        public List<CBBPhim> GetCBBPhim()
        {
            List<CBBPhim> data = new List<CBBPhim>();
            foreach (Phim i in db.Phims)
            {
                data.Add(new CBBPhim
                {
                    value = i.IDPhim,
                    text = i.TenPhim,
                });
            }
            return data;
        }
        public List<CBBLoaiManHinh> GetCBBLoaiManHinh()
        {
            List<CBBLoaiManHinh> data = new List<CBBLoaiManHinh>();
            foreach (LoaiManHinh i in db.LoaiManHinhs)
            {
                data.Add(new CBBLoaiManHinh
                {
                    value = i.IDLoaiManHinh,
                    text = i.TenManHinh,
                });
            }
            return data;
        }
        public DinhDangPhim GetDinhDangPhimByMaDinhDang(string IDDinhDangPhim)
        {
            return db.DinhDangPhims.Find(IDDinhDangPhim);
        }
        // -------------------Loại Màn Hình-----------------------
        public List<LoaiManHinhDTO> ShowLMH()
        {
            List<LoaiManHinhDTO> datalmh = new List<LoaiManHinhDTO>();
            datalmh = (from p in db.LoaiManHinhs
                       select
                       new LoaiManHinhDTO
                       {
                           ID_LoaiManHinh = p.IDLoaiManHinh,
                           TenManHinh = p.TenManHinh,
                       }).ToList();
            return datalmh;
        }
        public void ExecuteDBLoaiMH(LoaiManHinh lmh)
        {
            LoaiManHinh p = db.LoaiManHinhs.Find(lmh.IDLoaiManHinh);
            if (p != null)
            {
                p.IDLoaiManHinh = lmh.IDLoaiManHinh;
                p.TenManHinh = lmh.TenManHinh;
            }
            else
            {
                db.LoaiManHinhs.Add(lmh);
            }
            db.SaveChanges();
        }
        public LoaiManHinh GetLMHByIDLMH(string IDLoaiMH)
        {
            return db.LoaiManHinhs.Find(IDLoaiMH);
        }
        public List<CBBLoaiManHinh> GetCBBLoaiMH()
        {
            List<CBBLoaiManHinh> data = new List<CBBLoaiManHinh>();
            foreach (LoaiManHinh i in db.LoaiManHinhs)
            {
                data.Add(new CBBLoaiManHinh
                {
                    value = i.IDLoaiManHinh,
                    text = i.TenManHinh,
                });
            }
            return data;
        }
        public void DelLoaiMH(string IDLoaiMH)
        {
            foreach (PhongChieu i in db.PhongChieux)
            {
                if (i.IDManHinh == IDLoaiMH)
                {
                    db.PhongChieux.Remove(i);
                }
            }
            foreach (DinhDangPhim d in db.DinhDangPhims)
            {
                if (d.IDLoaiManHinh == IDLoaiMH)
                {
                    db.DinhDangPhims.Remove(d);
                }
            }
            LoaiManHinh lmh = db.LoaiManHinhs.Find(IDLoaiMH);
            db.LoaiManHinhs.Remove(lmh);
            db.SaveChanges();
        }

        // -----------------Phòng Chiếu--------------------
        public List<PhongChieuDTO> ShowPhongChieu()
        {
            List<PhongChieuDTO> datapc = new List<PhongChieuDTO>();
            datapc = (from p in db.PhongChieux
                      select
                      new PhongChieuDTO
                      {
                          IDPhongChieu = p.IDPhongChieu,
                          TenPhong = p.TenPhong,
                          IDManHinh = p.IDManHinh,
                          SoChoNgoi = (int)p.SoChoNgoi,
                          TinhTrang = p.TinhTrang,
                          SoHangGhe = (int)p.SoHangGhe,
                          SoGhe1Hang = (int)p.SoGheMotHang,
                          
                      }).ToList();
            return datapc;
        }
        public void ExecuteDBPhongChieu(PhongChieu pc)
        {
            PhongChieu p = db.PhongChieux.Find(pc.IDPhongChieu);
            if (p != null)
            {
                p.IDPhongChieu = pc.IDPhongChieu;
                p.TenPhong = pc.TenPhong;
                p.IDManHinh = pc.IDManHinh;
                p.SoChoNgoi = Convert.ToInt32(pc.SoChoNgoi);
                p.TinhTrang = pc.TinhTrang;
                p.SoHangGhe = Convert.ToInt32(pc.SoHangGhe);
                p.SoGheMotHang = Convert.ToInt32(pc.SoGheMotHang);
            }
            else
            {
                db.PhongChieux.Add(pc);
            }
            db.SaveChanges();
        }
        public PhongChieu GetPCByIDPC(string IDPhongChieu)
        {
            return db.PhongChieux.Find(IDPhongChieu);
        }
        public void DelPhongChieu(string IDPC)
        {
            foreach (LichChieu i in db.LichChieux)
            {
                if (i.IDPhong == IDPC)
                {
                    db.LichChieux.Remove(i);
                }
            }
            PhongChieu pc = db.PhongChieux.Find(IDPC);
            db.PhongChieux.Remove(pc);
            db.SaveChanges();
        }


        //-----------------LichChieu------------
        public List<LichChieuDTO> ShowLichChieu()
        {
            List<LichChieuDTO> dataLichChieu = new List<LichChieuDTO>();
            dataLichChieu = (from p in db.LichChieux
                             select
                   new LichChieuDTO
                   {
                       IDLichChieu = p.IDLichChieu,
                       ThoiGianChieu = (DateTime)p.ThoiGianChieu,
                       IDPhong = p.IDPhong,
                       IDDinhDang = p.IDDinhDang,
                       GiaVe = p.GiaVe,
                       TrangThai = p.TrangThai,
                       TenPhong = p.PhongChieu.TenPhong,
                       TenPhim = p.DinhDangPhim.Phim.TenPhim,
                   }).ToList();
            return dataLichChieu;
        }

        public List<CBBPhongChieu> GetCBBPhongChieu()
        {
            List<CBBPhongChieu> data = new List<CBBPhongChieu>();
            foreach (PhongChieu i in db.PhongChieux)
            {
                data.Add(new CBBPhongChieu
                {
                    value = i.IDPhongChieu,
                    text = i.TenPhong,
                });
            }
            return data;
        }
        public List<CBBDinhDang> GetCBBDinhDang()
        {
            List<CBBDinhDang> data = new List<CBBDinhDang>();
            foreach (DinhDangPhim i in db.DinhDangPhims)
            {
                data.Add(new CBBDinhDang
                {
                    value = i.IDDinhDangPhim,
                    text = i.IDPhim,
                    text1 = i.IDLoaiManHinh,
                });
            }
            return data;
        }


        // -------------------Bán vé-----------------------
        //public List<LichChieu> GetAllListLichChieu()
        //{
        //    var listLichChieu;
        //    try
        //    {
        //         listLichChieu = db.LichChieux.Select(p =>
        //        new { p.PhongChieu.TenPhong, p.DinhDangPhim.Phim.TenPhim, p.ThoiGianChieu, p.TrangThai });
        //           // (List<LichChieu>)(from p in db.LichChieux
        //           //select new { p.PhongChieu.TenPhong, p.DinhDangPhim.Phim.TenPhim, p.ThoiGianChieu, p.TrangThai });
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //        return listLichChieu;
        //}
        public  List<LichChieuDTO> GetAllListShowTimes()
        {
            List<LichChieuDTO> listShowTimes = new List<LichChieuDTO>();
            DataTable data = Data.ExecuteQuery("USP_GetAllListShowTimes");
            foreach (DataRow row in data.Rows)
            {
                LichChieuDTO showTimes = new LichChieuDTO(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public  List<LichChieuDTO> GetListShowTimesNotCreateTickets()
        {
            List<LichChieuDTO> listShowTimes = new List<LichChieuDTO>();
            DataTable data = Data.ExecuteQuery("USP_GetListShowTimesNotCreateTickets");
            foreach (DataRow row in data.Rows)
            {
                LichChieuDTO showTimes = new LichChieuDTO(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static PhongChieuDTO GetCinemaByName(string cinemaName)
        {
            //MessageBox.Show(cinemaName);
            string query = "select * from dbo.PhongChieu where TenPhong = '" + cinemaName + "'";
            DataTable data = Data.ExecuteQuery(query);
            return new PhongChieuDTO(data.Rows[0]);
        }
        public  int InsertTicketByShowTimes(string showTimesID, string seatName)
        {
            string query = "USP_InsertTicketByShowTimes @idlichChieu , @maGheNgoi";
            return Data.ExecuteNonQuery(query, new object[] { showTimesID, seatName });
        }
        public  int UpdateStatusShowTimes(string showTimesID, int status)
        {
            string query = "USP_UpdateStatusShowTimes @idLichChieu , @status";
            return Data.ExecuteNonQuery(query, new object[] { showTimesID, status });
        }
        public void AutoCreateTicketsByShowTimes(LichChieuDTO lichchieu)
        {
            int result = 0;
            PhongChieuDTO phongChieu = GetCinemaByName(lichchieu.IDPhong);
            int Row = phongChieu.SoHangGhe;
            int Column = phongChieu.SoGhe1Hang;
            for (int i = 0; i < Row; i++)
            {
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 1; j <= Column; j++)
                {
                    string seatName = nameRow.ToString() + j;
                    result += InsertTicketByShowTimes(lichchieu.IDLichChieu, seatName);
                }
            }
            if(lichchieu.TrangThai == "1")
            {
                MessageBox.Show("Lịch chiếu  Đã được tạo!!");
            }    
            else if (result == Row * Column)
            {
                int ret = UpdateStatusShowTimes(lichchieu.IDLichChieu, 1);
                if (ret > 0)
                    MessageBox.Show("TẠO VÉ TỰ ĐỘNG THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("TẠO VÉ TỰ ĐỘNG THẤT BẠI!", "THÔNG BÁO");
            //int result = 0;

   
            //PhongChieuDTO phongChieu = GetCinemaByName(lichchieu.IDPhong);
            ////MessageBox.Show(lichchieu.TenPhong.ToString());
            //string idLichChieu = lichchieu.IDLichChieu;
            //int Row = Convert.ToInt32(phongChieu.SoHangGhe);
            //int Column = Convert.ToInt32(phongChieu.SoGhe1Hang);
            //int ret = 0;
            //if (result == Row * Column)
            //{
            //    LichChieu lichChieu = db.LichChieux.Find(idLichChieu);
            //    lichchieu.TrangThai = "1";
            //    ret = 1;
            //    if (ret > 0)
            //        MessageBox.Show("TẠO VÉ TỰ ĐỘNG THÀNH CÔNG!", "THÔNG BÁO");
            //}
            //else
            //    MessageBox.Show("TẠO VÉ TỰ ĐỘNG THẤT BẠI!", "THÔNG BÁO");
        }
        public static int DeleteTicketsByShowTimes(string showTimesID)
        {
            string query = "USP_DeleteTicketsByShowTimes @idlichChieu";
            return Data.ExecuteNonQuery(query, new object[] { showTimesID });
        }
        public void DeleteTicketsByShowTimes(LichChieuDTO showTimes)
        {
            PhongChieuDTO cinema = GetCinemaByName(showTimes.IDPhong);
            //MessageBox.Show(cinema.ToString());
            int Row = cinema.SoHangGhe;
            int Column = cinema.SoGhe1Hang;
            //MessageBox.Show(Row.ToString(), Column.ToString());
            DeleteTicketsByShowTimes(showTimes.IDLichChieu);
            //MessageBox.Show(result.ToString());
            if (showTimes.TrangThai =="1")
            {
                //MessageBox.Show("2");
                int ret = UpdateStatusShowTimes(showTimes.IDLichChieu, 0);
                if (ret > 0)
                    MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.IDLichChieu + " THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.IDLichChieu + " THẤT BẠI!", "THÔNG BÁO");
        }
        public List<Phim> GetPhimByNgayKC_KT(DateTime date)
        {
            List<Phim> dataphim = new List<Phim>();
            try
            {
                dataphim = ((db.Phims.Where(p => date <= p.NgayKetThuc)).ToList());
                ////db.Phims.Where(p => date <= p.NgayKetThuc); 
                //foreach (DataRow row in data.Rows)
                //{
                //    PhimDTO phim = new PhimDTO(row);
                //    dataphim.Add(phim);
                //}
                //
                //DataTable data = DataProvider.ExecuteQuery("select * from Phim where @Date <= NgayKetThuc", new object[] { date });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataphim;

        }
        public string GetIDPhim(string name)
        {

            string idphim = "";
            foreach (Phim i in db.Phims)
            {
                if (i.TenPhim == name)
                {
                    idphim = i.IDPhim;
                }
            }
            return idphim;
        }
    }
}
