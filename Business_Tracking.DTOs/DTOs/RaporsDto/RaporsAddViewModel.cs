using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.DTOs.DTOs.RaporsDto
{
    public class RaporsAddViewModel:BaseEntity
    {

        public string Description { get; set; }

        public string Details { get; set; }

        public int JobsID { get; set; }

        public Jobs Jobs { get; set; }

    }
}
