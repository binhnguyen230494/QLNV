using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.WEB.Models.NhanVien
{
    public class TaoNhanVien
    {
        
        public int PhongBanId { get; set; }
        [Display(Name = "Họ")]
        [Required(ErrorMessage = "Bạn phải nhập họ")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "Họ phải có 1 kí tự")]
        public string Ho { get; set; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Bạn phải nhập Tên")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "Mã Phòng Ban phải có 1 kí tự")]
        
        public string Ten { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Display(Name = "Điện Thoại")]
        public string DienThoai { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Email không đúng định dạng")]
        public string Email { get; set; }
    }
}
