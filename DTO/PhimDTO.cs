using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class PhimDTO
    {
        public string idPhim { get; set; }

        public string tenPhim { get; set; }

        public double thoiLuong { get; set; }

        public DateTime ngayKC { get; set; }

        public DateTime ngayKT { get; set; }

        public string sanXuat { get; set; }

        public int namSanXuat { get; set; }

        public string daoDien { get; set; }

        public string idTheLoai { get; set; }

    }
}
