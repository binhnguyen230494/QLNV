using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLNV.WEB.Models.NhanVien;

namespace QLNV.WEB.Controllers
{
    public class NhanVienController : Controller
    {
        private static int phongbanid = 0;
        public IActionResult Index(int id)
        {
            
            var nhanviens = new List<NhanVienVM>();
            var url = $"{common.Common.ApiUrl}/nhanvien/danhsachnhanvien/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                nhanviens = JsonConvert.DeserializeObject<List<NhanVienVM>>(responseData);

            }
            phongbanid = id;
            ViewBag.TenPhongBan = DanSachPhongBan().Where(p => p.ID == id).FirstOrDefault().TenPhongBan;
            return View(nhanviens);
        }
        public IActionResult TaoNhanVien()
        {
            ViewBag.Phongbans = DanSachPhongBan();
            ViewBag.Phongbanid = phongbanid;
            return View();
        }
        [HttpPost]
        public IActionResult TaoNhanVien(TaoNhanVien model)
        {
            int ketqua = 0;
            var url = $"{common.Common.ApiUrl}/nhanvien/taonhanvien";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWrite.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resketqua = streamReader.ReadToEnd();
                ketqua = int.Parse(resketqua);
            }
            if (ketqua > 0)
            {
                TempData["Thanhcong"] = "Dẫ tạo nhân viên thành công";
                //return RedirectToAction("Index", "NhanVien");
            }
            ModelState.Clear();
            ViewBag.Phongbans = DanSachPhongBan();
            ViewBag.Phongbanid = phongbanid;
            return View(new TaoNhanVien() { });
        }
        public IActionResult SuaNhanVien(int id)
        {
            var nhanvien = new SuaNhanVien();
            var url = $"{common.Common.ApiUrl}/nhanvien/suanhanvien/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                nhanvien = JsonConvert.DeserializeObject<SuaNhanVien>(responseData);

            }
            ViewBag.Phongbans = DanSachPhongBan();
            ViewBag.Phongbanid = phongbanid;
            TempData["Loi"] = null;
            TempData["Success"] = null;
            return View(nhanvien);
        }
        [HttpPost]
        public IActionResult SuaNhanVien(SuaNhanVien model)
        {
            int ketqua = 0;
            var url = $"{common.Common.ApiUrl}/nhanvien/suanhanvien";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWrite.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resketqua = streamReader.ReadToEnd();
                ketqua = int.Parse(resketqua);
            }
            ViewBag.Phongbans = DanSachPhongBan();
            ViewBag.Phongbanid = phongbanid;
            if (ketqua > 0)
            {
                TempData["Thanhcong"] = "Dẫ cập nhật nhân viên thành công";
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Loi"] = "Không thể cập nhật kết quả";
                return RedirectToAction("Index");
            }

            // return View(new SuaPhongBan() { });
        }
        private List<PhongBanItem> DanSachPhongBan()
        {
            var phongbans = new List<PhongBanItem>();
            var url = $"{common.Common.ApiUrl}/phongban/danhsachphongban";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                phongbans = JsonConvert.DeserializeObject<List<PhongBanItem>>(responseData);

            }
            return phongbans;
        }
        
        
    }
}
