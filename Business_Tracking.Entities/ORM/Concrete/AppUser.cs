using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Entities.ORM.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Image { get; set; }

        public List<Jobs> Jobs { get; set; }

        public List<Notification> Notifications { get; set; }

    }
}
