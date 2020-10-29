using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Repository.Repository.Abstract
{
    public interface INotificationRepository:IBaseRepository<Notification>
    {

        List<Notification> NotRead(int userid);
        List<Notification> Read(int userid);

        
    }
}
