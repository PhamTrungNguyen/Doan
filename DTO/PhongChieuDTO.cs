using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class PhongChieuDTO
    {
        public string IDPhongChieu { get; set; }
        public string TenPhong { get; set; }
        public string IDManHinh { get; set; }
        public int SoChoNgoi { get; set; }
        public string TinhTrang { get; set; }
        public int SoHangGhe { get; set; }
        public int SoGhe1Hang { get; set; }
        public PhongChieuDTO()
        {

        }
        public PhongChieuDTO(DataRow row)
        {
            this.IDPhongChieu = row["iDPhongChieu"].ToString();
            this.TenPhong = row["TenPhong"].ToString();
            this.IDManHinh = row["idManHinh"].ToString();
            this.SoChoNgoi = (int)row["SoChoNgoi"];
            this.TinhTrang = row["TinhTrang"].ToString();
            this.SoHangGhe = (int)row["SoHangGhe"];
            this.SoGhe1Hang = (int)row["SoGheMotHang"];
        }
    }

}
