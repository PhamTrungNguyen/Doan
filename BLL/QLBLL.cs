using DoAn.DTO;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
