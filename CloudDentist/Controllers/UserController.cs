using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudDentist.Models;
using CloudDentist.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudDentist.Controllers
{
    public class UserController : Controller
    {
        public IActionResult IndexRegister(UserModel user)
        {
            return View();
        }
        public ActionResult Register(UserModel user)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                string stringData = JsonConvert.SerializeObject(user);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/register", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return RedirectToAction("Pengguna", "DaftarPengguna");
                }
                else
                {
                    return View();
                }
            }
        }
        public ActionResult Pasien_register(UserModel obj)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                client.BaseAddress = new Uri("http://localhost:30512");
                string stringData = JsonConvert.SerializeObject(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/registerpasien", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                  
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
        }
        public ActionResult listuser()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512/");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));

                var token = HttpContext.Session.GetString("JWTtoken");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/User/getall").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<UserModel> data = JsonConvert.DeserializeObject<List<UserModel>>(stringData);
                return View(data);
            }
        }
        public ActionResult ManageRole(string Username)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                if (Username == null)
                {
                    return View(new UserModel());

                }
                else
                {
                    HttpResponseMessage response = client.GetAsync("/api/user/profile/?Username=" + Username).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    ProfileViewModel data = JsonConvert.DeserializeObject<ProfileViewModel>(stringData);
                    //List<ProfileViewModel> data2 = JsonConvert.DeserializeObject<List<ProfileViewModel>>(stringData);
                    TempData["currentrole"] = data.currentrole;

                    ViewBag.returnUrl = Request.Headers["Referer"].ToString();
                    return View(data);
                }
            }
        }
        [HttpPost]
        public ActionResult Managerole(ProfileViewModel obj, string returnUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                if (TempData["currentrole"] != null)
                {
                    obj.currentrole = TempData["currentrole"].ToString();
                }
                else
                {
                    obj.currentrole = "";
                }

               
                if (obj.Username == null)
                {
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("/api/UserRole", contentData).Result;

                    ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;


                }
                else
                {
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("/api/UserRole/editusertorole", contentData).Result;
                    ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;

                }
                return View();
            }
        }
        public ActionResult userlist(string roleName)
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
                HttpResponseMessage response = client.GetAsync("/api/UserRole/GetUserRole/?roleName=" + roleName).Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<UserModel> data = JsonConvert.DeserializeObject<List<UserModel>>(stringData);
                if (response.StatusCode == HttpStatusCode.BadRequest|| response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
                }
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }     
    }
}