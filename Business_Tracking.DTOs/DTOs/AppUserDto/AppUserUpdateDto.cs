﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.DTOs.DTOs.AppUserDto
{
    public class AppUserUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string email { get; set; }

        public string username { get; set; }
        public string Image { get; set; }
    }
}

