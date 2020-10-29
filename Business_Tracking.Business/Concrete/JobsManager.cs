using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business_Tracking.Business.Concrete
{
    public class JobsManager : IJobsService
    {

        private IJobsRepository _jobsRepository;

        public JobsManager(IJobsRepository jobsRepository)
        {
            _jobsRepository = jobsRepository;

        }
        public void Add(Jobs entity)
        {
            _jobsRepository.Add(entity);
        }

        public List<Jobs> AllTables()
        {
            return _jobsRepository.AllTables();
        }

        public void Delete(Jobs entity)
        {
            _jobsRepository.Delete(entity);
        }

        public List<Jobs> EndDuty(out int page, int userid, int sumpage)
        {
            return _jobsRepository.EndDuty(out page,userid,sumpage);
        }

        public List<Jobs> GetAll()
        {
            return _jobsRepository.GetAll();
        }

        public List<Jobs> GetAll(Expression<Func<Jobs, bool>> expression)
        {
            return _jobsRepository.GetAll(expression);
        }

        public Jobs GetByid(int id)
        {
            return _jobsRepository.GetByid(id);
        }

        public Jobs GetOne(Expression<Func<Jobs, bool>> expression)
        {
            return _jobsRepository.GetOne(expression);
        }

        public int SumJobs(int userid)
        {
            return _jobsRepository.SumJobs(userid);
        }

        public int SumNotJobs(int userid)
        {
            return _jobsRepository.SumNotJobs(userid);
        }

        public void Update(Jobs entity)
        {
            _jobsRepository.Update(entity);
        }

        public Jobs WithRapor(int id)
        {
            return _jobsRepository.WithRapor(id);
        }

        public List<Jobs> WithUrgency()
        {
            return _jobsRepository.WithUrgency();
        }

        public Jobs WithUrgency(int id)
        {
            return _jobsRepository.WithUrgency(id);
        }

        public List<Jobs> WithUser(int userid)
        {

            return _jobsRepository.WithUser(userid);
        }

        public List<Jobs> WithWork(int userid)
        {
            return _jobsRepository.WithWork(userid);
        }
    }
}
