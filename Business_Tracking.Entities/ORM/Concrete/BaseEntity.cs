﻿using Business_Tracking.Entities.ORM.Abstract;
using Business_Tracking.Entities.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Entities.ORM.Concrete
{
    public class BaseEntity : ICore
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;

        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        private Status _status = Status.Active;

        public Status status { get { return _status; } set { _status = value; } }
    }
}
