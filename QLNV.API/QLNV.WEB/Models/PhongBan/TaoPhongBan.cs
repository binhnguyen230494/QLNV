using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.WEB.Models.PhongBan
{
    public class TaoPhongBan
    {
        [Display(Name = "Mã Phòng Ban")]
        [Required(ErrorMessage = "Bạn phải nhập mã phong ban")]
        [StringLength(maximumLength:50, MinimumLength =1, ErrorMessage ="Mã Phòng Ban phải có 1 kí tự")]
        public string MaPhongBan { get; set; }
        [Display(Name = "Tên Phòng Ban")]
        [Required(ErrorMessage = "Bạn phải nhập tên phong ban")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "Tên Phòng Ban phải có 4 kí tự")]
        public string TenPhongBan { get; set; }
    }
}
