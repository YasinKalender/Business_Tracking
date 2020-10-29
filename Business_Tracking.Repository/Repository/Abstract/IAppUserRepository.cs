
using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Repository.Repository.Abstract
{
    public interface IAppUserRepository
    {


        List<AppUser> NotAdmin();

        List<AppUser> NotAdmin(out int sumpage, string search,int activepage=1);


    }
}
