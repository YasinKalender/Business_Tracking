using Business_Tracking.DAL.Context;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Repository.Repository.Concrete
{
    public class UrgencyRepository:BaseRepository<Urgency>,IUrgencyRepository
    {
        public UrgencyRepository(ProjectContext projectContext) :base(projectContext)
        {

        }

    }
}
