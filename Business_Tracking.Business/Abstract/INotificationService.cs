using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.Abstract
{
    public interface INotificationService:IBaseService<Notification>
    {

        List<Notification> NotRead(int userid);
    }
}
