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
    public class PhongBanController : ControllerBase
    {
        private readonly IPhongBanService _phongBanService;
        public PhongBanController(IPhongBanService phongBanService)
        {
            _phongBanService = phongBanService;
        }
        [Route("api/phongban/danhsachphongban")]
        [HttpGet]
        public IEnumerable<PhongBan> DanhSachPhongBan()
        {
            return _phongBanService.DanhSachPhongBan();
        }

        [Route("api/phongban/layphongban/{id}")]
        [HttpGet("{id}")]
        public PhongBan LayPhongBanID(int id)
        {
            return _phongBanService.LayPhongBanID(id);
        }
        [Route("api/phongban/taophongban")]

        [HttpPost]
        public int TaoPhongBan([FromBody] TaoPhongBan request)
        {
            return _phongBanService.TaoPhongBan(request);
        }
        [Route("api/phongban/suaphongban")]

        [HttpPut("{id}")]
        public int SuaPhongBan([FromBody] SuaPhongBan request)
        {
            return _phongBanService.SuaPhongBan(request);
        }

        [Route("api/phongban/xoaphongban/{id}")]
        [HttpDelete]
        public bool XoaPhongBan(int id)
        {
            return _phongBanService.XoaPhongBan(id);
        }
    }
}
