using CloudDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.ViewModel
{
    public class ProfileViewModel
    {
        public ProfileViewModel()
        {
            this.UserRole = new List<UserRole>();

        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        //ganti ke list untuk EXPERIMEN ROLE LEBIH DARI 1
        public string rolename { get; set; }
        public string currentrole { get; set; }
        public string selectrole { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}
