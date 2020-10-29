using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.Abstract
{
    public interface IAppUserService
    {

        List<AppUser> NotAdmin();
        List<AppUser> NotAdmin(out int sumpage,string search, int activepage);

       
    }
}
