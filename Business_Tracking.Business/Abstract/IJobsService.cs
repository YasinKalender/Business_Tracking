using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.Abstract
{
    public interface IJobsService:IBaseService<Jobs>
    {

        List<Jobs> WithUrgency();
        List<Jobs> AllTables();
       Jobs WithUrgency(int id);

        List<Jobs> WithUser(int userid);

        Jobs WithRapor(int id);

        List<Jobs> WithWork(int userid);

        List<Jobs> EndDuty(out int page, int userid, int sumpage);
        int SumJobs(int userid);

        int SumNotJobs(int userid);
    }
}
