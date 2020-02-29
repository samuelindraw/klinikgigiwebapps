using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CloudDentist.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudDentist.Controllers
{
    public class PenggunaController : Controller
    {
        public IActionResult DaftarPengguna()
        {
            return View();
        }
        public ActionResult penggunaregister(Pengguna pengguna)
        {
            using (HttpClient client = new HttpClient())
            {
                pengguna.Username = "dummy4";
                
                client.BaseAddress = new Uri("http://localhost:30512");
                string stringData = JsonConvert.SerializeObject(pengguna);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/Pengguna", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                 
                    return RedirectToAction("User", "userlist");
                }
                else
                {
                    return View();
                }
            }
        }

    }
}