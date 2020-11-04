using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLNV.BAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLNV.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _nhanVienService;
        public NhanVienController(INhanVienService nhanVienService)
        {
            _nhanVienService = nhanVienService;
        }
        [Route("api/nhanvien/danhsachnhanvien/{id}")]
        [HttpGet("{id}")]
        public IEnumerable<NhanVien> DanhSachNVTheoPB(int id)
        {
            return _nhanVienService.DanhSachNVTheoPB(id);
        }

        [Route("api/nhanvien/laynhanvien/{id}")]
        [HttpGet("{id}")]
        public NhanVien LayNhanVien(int id)
        {
            return _nhanVienService.LayNhanVienTheoMaNV(id);
        }
        [Route("api/nhanvien/taonhanvien")]

        [HttpPost]
        public int TaoNhanVien([FromBody] TaoNhanVien request)
        {
            return _nhanVienService.TaoNhanVien(request);
        }
        [Route("api/nhanvien/suanhanvien")]

        [HttpPut("{id}")]
        public int SuaNhanVien([FromBody] SuaNhanVien request)
        {
            return _nhanVienService.SuaNhanVien(request);
        }

        [Route("api/nhanvien/xoanhanvien/{id}")]
        [HttpDelete]
        public bool XoaNhanVien(int id)
        {
            return _nhanVienService.XoaNhanVien(id);
        }
    }
}
