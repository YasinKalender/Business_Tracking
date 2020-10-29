using Business_Tracking.DAL.Context;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Tracking.Repository.Repository.Concrete
{
    public class JobsRepository:BaseRepository<Jobs>,IJobsRepository
    {

        private ProjectContext _projectContext;
        public JobsRepository(ProjectContext projectContext):base(projectContext)
        {
            _projectContext = projectContext;
        }

        public List<Jobs> AllTables()
        {
            return _projectContext.Jobs.Include(i => i.Rapors).Include(i => i.AppUser).Include(i => i.Urgency).Where(i=>i.status==Entities.ORM.Enum.Status.Active).ToList();
        }

        public List<Jobs> EndDuty(out int page,int userid,int sumpage)
        {
            var returnValue = _projectContext.Jobs.Where(i => i.AppUserID == userid && i.status == Entities.ORM.Enum.Status.Passive);
            page = (int)Math.Ceiling((double)returnValue.Count() / 3);
            

            return returnValue.Skip((sumpage - 1) * 3).Take(3).ToList();


        }

        public int SumJobs(int userid)
        {
            return _projectContext.Jobs.Where(i => i.AppUserID == userid && i.status==Entities.ORM.Enum.Status.Passive).Count();
        }

        public int SumNotJobs(int userid)
        {
            return _projectContext.Jobs.Where(i => i.AppUserID == userid && i.status==Entities.ORM.Enum.Status.Active).Count();
        }

        public Jobs WithRapor(int id)
        {
            return _projectContext.Jobs.Include(i => i.Rapors).Include(i=>i.AppUser).Where(i => i.ID == id).FirstOrDefault();
        }

        public List<Jobs> WithUrgency()
        {
            return  _projectContext.Jobs.Include(i => i.Urgency).OrderByDescending(i=>i.AddDate).ToList();
        }

        public Jobs WithUrgency(int id)
        {
            return _projectContext.Jobs.Include(i => i.Urgency).FirstOrDefault(i => i.ID==id && i.status == Entities.ORM.Enum.Status.Active);
        }

        public List<Jobs> WithUser(int userid)
        {
            return _projectContext.Jobs.Include(i => i.AppUser).Where(i => i.AppUserID == userid).ToList();
        }

        public List<Jobs> WithWork(int userid)
        {
            return _projectContext.Jobs.Include(i=>i.Rapors).Include(i=>i.AppUser).Include(i=>i.Urgency).Where(i => i.AppUserID == userid && i.status == Entities.ORM.Enum.Status.Active).OrderByDescending(i => i.AddDate).ToList();
        }
    }
}
