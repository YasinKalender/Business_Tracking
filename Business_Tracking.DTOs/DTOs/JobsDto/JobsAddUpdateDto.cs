using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.DTOs.DTOs.JobsDto
{
    public class JobsAddUpdateDto:BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public int UrgencyID { get; set; }

        public virtual Urgency Urgency { get; set; }
    }
}
