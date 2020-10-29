using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business_Tracking.Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {

        private IUrgencyRepository _urgencyRepository;

        public UrgencyManager(IUrgencyRepository urgencyRepository)
        {
            _urgencyRepository = urgencyRepository;
        }
        public void Add(Urgency entity)
        {
            _urgencyRepository.Add(entity);
        }

        public void Delete(Urgency entity)
        {
            _urgencyRepository.Delete(entity);
        }

        public List<Urgency> GetAll()
        {
            return _urgencyRepository.GetAll().ToList();
        }

        public List<Urgency> GetAll(Expression<Func<Urgency, bool>> expression)
        {
            return _urgencyRepository.GetAll(expression).ToList();
        }

        public Urgency GetByid(int id)
        {
            return _urgencyRepository.GetByid(id);
        }

        public Urgency GetOne(Expression<Func<Urgency, bool>> expression)
        {
            return _urgencyRepository.GetOne(expression);
        }

        public void Update(Urgency entity)
        {
            _urgencyRepository.Update(entity);
        }
    }
}
