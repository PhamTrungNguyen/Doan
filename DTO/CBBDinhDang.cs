using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DTO
{
    public class CBBDinhDang
    {
        public string value { get; set; }
        public string text { get; set; }
        public string text1 { get; set; }
        public override string ToString()
        {
            return value;
        }
    }
}
