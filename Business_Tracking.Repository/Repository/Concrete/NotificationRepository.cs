using Business_Tracking.DAL.Context;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Tracking.Repository.Repository.Concrete
{
    public class NotificationRepository:BaseRepository<Notification>,INotificationRepository
    {

        private ProjectContext _projectContext;

        public NotificationRepository(ProjectContext projectContext):base(projectContext)
        {
            _projectContext = projectContext;
        }

        public List<Notification> NotRead(int userid)
        {
            return _projectContext.Notifications.Where(i => i.AppUserID == userid && i.status==Entities.ORM.Enum.Status.Active).ToList();
        }

        public List<Notification> Read(int userid)
        {
            throw new NotImplementedException();
        }
    }
}
