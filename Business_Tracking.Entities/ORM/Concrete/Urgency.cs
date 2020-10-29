using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Entities.ORM.Concrete
{
    public class Urgency:BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Jobs> Jobs { get; set; }

    }
}
