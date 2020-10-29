using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business_Tracking.Business.Concrete
{
    public class RaporManager : IRaporService
    {
        private IRaporRepository _raporRepository;

        public RaporManager(IRaporRepository raporRepository)
        {
            _raporRepository = raporRepository;
        }

        public void Add(Rapor entity)
        {
            _raporRepository.Add(entity);
        }

        public void Delete(Rapor entity)
        {
            throw new NotImplementedException();
        }

        public List<Rapor> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Rapor> GetAll(Expression<Func<Rapor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Rapor GetByid(int id)
        {
          return _raporRepository.GetByid(id);
        }

        public Rapor GetOne(Expression<Func<Rapor, bool>> expression)
        {
           return _raporRepository.GetOne(expression);
        }

        public int SumRapor(int userid)
        {
            return _raporRepository.SumRapor(userid);
        }

        public void Update(Rapor entity)
        {
            _raporRepository.Update(entity);
        }

        public Rapor WithJob(int id)
        {
            return _raporRepository.WithJob(id);
        }
    }
}
