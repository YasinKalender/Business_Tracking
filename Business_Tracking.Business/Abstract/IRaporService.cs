using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.Abstract
{
    public interface IRaporService:IBaseService<Rapor>
    {

        Rapor WithJob(int id);

        int SumRapor(int userid);
    }
}
