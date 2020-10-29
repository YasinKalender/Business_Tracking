using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Repository.Repository.Abstract
{
    public interface IRaporRepository:IBaseRepository<Rapor>
    {
        Rapor WithJob(int id);

       int SumRapor(int userid);

    }
}
