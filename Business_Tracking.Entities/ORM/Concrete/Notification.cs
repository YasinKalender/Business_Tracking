using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Entities.ORM.Concrete
{
    public class Notification:BaseEntity
    {

        public string Description { get; set; }

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }
    }
}
