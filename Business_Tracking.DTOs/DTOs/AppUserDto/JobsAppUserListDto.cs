using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.DTOs.DTOs.AppUserDto
{
    public class JobsAppUserListDto
    {
        public AppUser AppUser{ get; set; }

        public Jobs Jobs { get; set; }

    }
}
