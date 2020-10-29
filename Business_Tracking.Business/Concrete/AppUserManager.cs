using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {

        private IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
        public List<AppUser> NotAdmin()
        {
            return _appUserRepository.NotAdmin();
        }

        public List<AppUser> NotAdmin(out int sumpage,string search, int activepage)
        {
            return _appUserRepository.NotAdmin(out sumpage,search, activepage);
        }
    }
}
