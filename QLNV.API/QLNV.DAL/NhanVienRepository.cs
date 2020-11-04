using Dapper;
using QLNV.DAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLNV.DAL
{
    public class NhanVienRepository : BaseRepository, INhanVienRepository
    {
        public IList<NhanVien> DanhSachNVTheoPB(int PhongBanId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PhongBanId", PhongBanId);
            IList<NhanVien> NVlist = SqlMapper.Query<NhanVien>(con, "DanhSachNhanVienTheoPhongBan", parameters,commandType: CommandType.StoredProcedure).ToList();
            return NVlist;
        }

        public NhanVien LayNhanVienTheoMaNV(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaNV", Id);
            NhanVien NV = SqlMapper.Query<NhanVien>(con, "LayNhanVienTheoMaNV", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return NV;
        }

        public int SuaNhanVien(SuaNhanVien request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNV", request.MaNV);
                parameters.Add("@Ho", request.Ho);
                parameters.Add("@Ten", request.Ten);
                parameters.Add("@PhongBanId", request.PhongBanId);
                parameters.Add("@DiaChi", request.DiaChi);
                parameters.Add("@DienThoai", request.DienThoai);

                var id = SqlMapper.ExecuteScalar<int>(con, "SuaNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TaoNhanVien(TaoNhanVien request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@PhongBanId", request.PhongBanId);
                parameters.Add("@Ho", request.Ho);
                parameters.Add("@Ten", request.Ten);
                parameters.Add("@DiaChi", request.DiaChi);
                parameters.Add("@DienThoai", request.DienThoai);
                parameters.Add("@Email", request.Email);
                var id = SqlMapper.ExecuteScalar<int>(con, "TaoNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaNhanVien(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNV", Id);

                var result = SqlMapper.ExecuteScalar<bool>(con, "XoaNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
