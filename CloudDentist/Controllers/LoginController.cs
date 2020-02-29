using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudDentist.Enums;
using CloudDentist.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static CloudDentist.Enums.Enums;

namespace CloudDentist.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(UserModel user)
        {
            return View();
        }
        public IActionResult Login(AuthenticateModel user)
        {
            statusmsg status = new statusmsg();
            using (HttpClient client = new HttpClient())
            {


                client.BaseAddress = new Uri("http://localhost:30512");
                string stringData = JsonConvert.SerializeObject(user);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/Login", contentData).Result;
                string data = response.Content.ReadAsStringAsync().Result;
                //HttpContext.Session.SetString("LoginRoles", Userloginroles);


                if (response.IsSuccessStatusCode)
                {
                    var DataUser = JsonConvert.DeserializeObject<UserModel>(data);
                    if (DataUser.rolename != null)
                    {
                        //convert from json response to Object Model
                        // take value from object model
                        HttpContext.Session.SetString("JWTtoken", DataUser.Token);
                        HttpContext.Session.SetString("Loginuser", DataUser.Username);
                        HttpContext.Session.SetString("Userrole", DataUser.rolename);
                        TempData["success"] = "success";
                        TempData["Pesan"] = "Login Berhasil !";
                        return RedirectToAction("Index", "Home");
                    }

                    else
                    {
                        TempData["error"] = "error";
                        TempData["Pesan"] = "Username atau password anda salah !";
                        return RedirectToAction("Index");
                    }
                   
                }

                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = "Username atau password anda salah !";
                    return RedirectToAction("Index");
                }
            }
        }
        public IActionResult Logout(UserModel user)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:30512");
            //    HttpResponseMessage response = client.PostAsync("/api/User/Logout").Result;
            //}
            HttpContext.Session.Clear();
            return Redirect("~/Login");
        }
    }
}