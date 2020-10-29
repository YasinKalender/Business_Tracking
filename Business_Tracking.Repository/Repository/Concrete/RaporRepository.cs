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
    public class RaporRepository:BaseRepository<Rapor>,IRaporRepository
    {
        private ProjectContext _projectContext;
        public RaporRepository(ProjectContext projectContext):base(projectContext)
        {
            _projectContext = projectContext;
        }

        public int SumRapor(int userid)
        {
            return _projectContext.Jobs.Include(i => i.Rapors).Where(i => i.AppUserID == userid).Count();
        }

        public Rapor WithJob(int id)
        {
            return _projectContext.Rapors.Include(i => i.Jobs).Where(i=>i.ID==id).FirstOrDefault();
        }
    }
}
