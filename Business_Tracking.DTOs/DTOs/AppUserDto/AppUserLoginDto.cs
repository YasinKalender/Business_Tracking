using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.DTOs.DTOs.AppUserDto
{
    public class AppUserLoginDto
    {

        public string username { get; set; }

        public string password { get; set; }

        public bool rememberMe { get; set; }
    }
}
