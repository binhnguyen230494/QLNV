using QLNV.Domain.Request;
using QLNV.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNV.BAL.Interface
{
    public interface INhanVienService
    {
        IList<NhanVien> DanhSachNVTheoPB(int PhongBanId);
        // csdl bitint thi c# dung long
        NhanVien LayNhanVienTheoMaNV(int Id);
        int TaoNhanVien(TaoNhanVien request);
        int SuaNhanVien(SuaNhanVien request);
        bool XoaNhanVien(int Id);
    }
}
