using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudDentist.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static CloudDentist.Enums.Enums;

namespace CloudDentist.Controllers
{
    public class BarangController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");

                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");


                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/Barang").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<Barang> data = JsonConvert.DeserializeObject<List<Barang>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult TambahEditData(int id = 0)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                if (id == 0)
                {
                    return View(new Barang());

                }
                else
                {
                    HttpResponseMessage response = client.GetAsync("/api/Barang/" + id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    KatBarang data = JsonConvert.DeserializeObject<KatBarang>(stringData);
                    TempData["SuccessMessage"] = "Saved Successfully";
                    return View(data);

                }
            }
        }

        [HttpPost]
        public ActionResult TambahEditData(Barang obj)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    
                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (obj.IdBarang == 0)
                    {
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/Barang", contentData).Result;
                        TempData["SuccessMessage"] = "Saved Successfully";
                        ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                        //var data1 = response.Content.ReadAsStringAsync().Result.ToList().ToString();
                    }
                    else
                    {
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/KatBarang/" + obj.IdBarang, contentData).Result;
                        TempData["SuccessMessage"] = "Data Dokter Tersimpan";
                        ViewBag.Message = response.Content.ReadAsStringAsync().Result;

                    }

                }
            }
            TempData["SuccessMessage"] = "Saved Successfully";
            return RedirectToAction("ManageDataDokter");
        }
        public ActionResult Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/Barang/" + id).Result;
                TempData["Message"] = response.Content.ReadAsStringAsync().Result;
                TempData["SuccessMessage"] = "Deleted Successfully";
                return RedirectToAction("Index");

            }
        }
        public ActionResult getbarangtenantid(int id = 0)
        {
            using (HttpClient client = new HttpClient())
            {
                if(id == 0)
                {
                    return View();
                }
                else
                {
                    client.BaseAddress = new Uri("http://localhost:30512");

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");


                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Barang/getbarangbykatbarang" + id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return Redirect("/Home/UnAuthorized");
                    }

                    List<Barang> data = JsonConvert.DeserializeObject<List<Barang>>(stringData);
                    //Aku lupa ini buat apa ? 
                    //var test = data.FirstOrDefault().Tenant.TenantName;
                    //HttpContext.Session.SetString("datatenant", test);
                    //var datatenant = HttpContext.Session.GetString("datatenant");
                    return View(data);
                }
            }
        }
    }
}