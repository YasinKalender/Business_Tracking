using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Entities.ORM.Concrete
{
    public class Rapor:BaseEntity
    {
        public string Description { get; set; }

        public string Details { get; set; }

        public int JobsID { get; set; }

        public virtual Jobs Jobs { get; set; }

    }
}
