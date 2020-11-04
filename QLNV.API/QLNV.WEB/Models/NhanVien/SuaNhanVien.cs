using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.WEB.Models.NhanVien
{
    public class SuaNhanVien
    {
        [Display(Name = "Mã Nhân Viên")]
        public int MaNV { get; set; }
        [Display(Name = "Mã Phòng Ban")]
        public int PhongBanId { get; set; }
        [Display(Name = "Họ")]
        public string Ho { get; set; }
        [Display(Name = "Tên")]
        public string Ten { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Điện Thoại")]
        public string DienThoai { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
