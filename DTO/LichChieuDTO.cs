using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class LichChieuDTO
    {
        public string IDLichChieu { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public string IDPhong { get; set; }
        public string IDDinhDang { get; set; }
        public string GiaVe { get; set; }
        public string TrangThai { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }
        public LichChieuDTO()
        {

        }
        public LichChieuDTO(string iD, DateTime time, string cinemaName,
         string formatMovieID, string movieName, string ticketPrice, string status)
        {
            this.IDLichChieu = iD;
            this.IDPhong = cinemaName;
            this.TenPhim = movieName;
            this.ThoiGianChieu = time;
            this.IDDinhDang = formatMovieID;
            this.GiaVe = ticketPrice;
            this.TrangThai = status;
        }

        public LichChieuDTO(DataRow row)
        {
            this.IDLichChieu = row["IDLichChieu"].ToString();
            this.IDPhong = row["TenPhong"].ToString();
            this.TenPhim = row["TenPhim"].ToString();
            this.ThoiGianChieu = (DateTime)row["ThoiGianChieu"];
            this.IDDinhDang = row["idDinhDang"].ToString();
            if (row["GiaVe"].ToString() == "")
                this.GiaVe = "0";
            else
                this.GiaVe =row["GiaVe"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }
    }
}
