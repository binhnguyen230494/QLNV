using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLNV.WEB.Models.PhongBan;

namespace QLNV.WEB.Controllers
{
    public class PhongBanController : Controller
    {
        // GET: PhongBanController
        public IActionResult Index()
        {
            var phongbans = new List<PhongBanVM>();
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
                phongbans = JsonConvert.DeserializeObject<List<PhongBanVM>>(responseData);

            }
            return View(phongbans);
        }

        // GET: PhongBanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public IActionResult TaoPhongBan()
        {
            TempData["Thanhcong"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult TaoPhongBan(TaoPhongBan model)
        {
            int ketqua = 0;
            var url = $"{common.Common.ApiUrl}/phongban/taophongban";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using(var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWrite.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using(var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resketqua = streamReader.ReadToEnd();
                ketqua = int.Parse(resketqua);
            }
            if(ketqua > 0)
            {
                TempData["Thanhcong"] = "Dẫ tạo phong ban thành công";
                return RedirectToAction("Index");
            }
            ModelState.Clear();
            return View(new TaoPhongBan() { });
        }

        public IActionResult SuaPhongBan(int id)
        {
            var phongban = new SuaPhongBan();
            var url = $"{common.Common.ApiUrl}/phongban/layphongban/{id}";
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
                phongban = JsonConvert.DeserializeObject<SuaPhongBan>(responseData);

            }
            return View(phongban);
        }
        [HttpPost]
        public IActionResult SuaPhongBan(SuaPhongBan model)
        {
            int ketqua = 0;
            var url = $"{common.Common.ApiUrl}/phongban/suaphongban";
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
                TempData["Thanhcong"] = "Dẫ cập nhật phong ban thành công";
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
        public IActionResult XoaPhongBan(int id)
        {
            var ketqua = false;
            var url = $"{common.Common.ApiUrl}/phongban/xoaphongban/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "DELETE";
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
                ketqua = JsonConvert.DeserializeObject<bool>(responseData);
                TempData["Thanhcong"] = "Dẫ xóa phong ban thành công";

            }
            return RedirectToAction("Index", "PhongBan");
        }
    }
}
