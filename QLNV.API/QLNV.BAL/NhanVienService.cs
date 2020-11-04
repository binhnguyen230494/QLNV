using QLNV.BAL.Interface;
using QLNV.DAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNV.BAL
{
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _nhanVienRepository;
        public NhanVienService(INhanVienRepository nhanVienRepository)
        {
            _nhanVienRepository = nhanVienRepository;
        }
        public IList<NhanVien> DanhSachNVTheoPB(int PhongBanId)
        {
            return _nhanVienRepository.DanhSachNVTheoPB(PhongBanId);
        }

        public NhanVien LayNhanVienTheoMaNV(int Id)
        {
            return _nhanVienRepository.LayNhanVienTheoMaNV(Id);
        }

        public int SuaNhanVien(SuaNhanVien request)
        {
            return _nhanVienRepository.SuaNhanVien(request);
        }

        public int TaoNhanVien(TaoNhanVien request)
        {
            return _nhanVienRepository.TaoNhanVien(request);
        }

        public bool XoaNhanVien(int Id)
        {
            return _nhanVienRepository.XoaNhanVien(Id);
        }
    }
}
