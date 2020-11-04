using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.WEB.Models.PhongBan
{
    public class PhongBanVM
    {
        public int ID { get; set; }
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public int TongSoNhanVien { get; set; }
    }
}
