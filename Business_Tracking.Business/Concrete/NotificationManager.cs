using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business_Tracking.Business.Concrete
{
    public class NotificationManager : INotificationService
    {

        private INotificationRepository _notificationRepository;

        public NotificationManager(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public void Add(Notification entity)
        {
            _notificationRepository.Add(entity);
        }

        public void Delete(Notification entity)
        {
            _notificationRepository.Delete(entity);
        }

        public List<Notification> GetAll()
        {
            return _notificationRepository.GetAll();
        }

        public List<Notification> GetAll(Expression<Func<Notification, bool>> expression)
        {
            return _notificationRepository.GetAll(expression);
        }

        public Notification GetByid(int id)
        {
            return _notificationRepository.GetByid(id);
        }

        public Notification GetOne(Expression<Func<Notification, bool>> expression)
        {
            return _notificationRepository.GetOne(expression);
        }

        public List<Notification> NotRead(int userid)
        {
            return _notificationRepository.NotRead(userid);
        }

        public void Update(Notification entity)
        {
            _notificationRepository.Update(entity);
        }
    }
}
