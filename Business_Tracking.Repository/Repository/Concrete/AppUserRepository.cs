using Business_Tracking.DAL.Context;
using Business_Tracking.Entities.ORM.Concrete;
using Business_Tracking.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Tracking.Repository.Repository.Concrete
{
    public class AppUserRepository :IAppUserRepository
    {
        private ProjectContext _projectContext;

        public AppUserRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

       

        //        Select* FROM AspNetUsers inner join AspNetUserRoles on AspNetUsers.Id=AspNetUserRoles.UserId
        //inner join AspNetRoles on AspNetUserRoles.RoleId= AspNetRoles.Id where AspNetRoles.Name= 'Member'

        public List<AppUser> NotAdmin()
        {
            return _projectContext.Users.Join(_projectContext.UserRoles, user => user.Id, userrole => userrole.UserId, (resultuser, resultrole) => new
            {
                user = resultuser,
                role = resultrole

            }).Join(_projectContext.Roles, twotableresult => twotableresult.role.RoleId, role => role.Id, (resulttwotable, role) => new
            {
              
                user=resulttwotable.user,
                resultuser=resulttwotable.role,
                roles=role


            }).Where(i=>i.roles.Name=="Member").Select(i=>new AppUser { 
            
            Id=i.user.Id,
            FirstName=i.user.FirstName,
            LastName=i.user.LastName,
            
            
            }).ToList();
        }

        public List<AppUser> NotAdmin(out int sumpage,string search, int activepage = 1)
        {
            var result = _projectContext.Users.Join(_projectContext.UserRoles, user => user.Id, userrole => userrole.UserId, (resultuser, resultrole) => new
            {
                user = resultuser,
                role = resultrole

            }).Join(_projectContext.Roles, twotableresult => twotableresult.role.RoleId, role => role.Id, (resulttwotable, role) => new
            {

                user = resulttwotable.user,
                resultuser = resulttwotable.role,
                roles = role


            }).Where(i => i.roles.Name == "Member").Select(i => new AppUser
            {

                Id = i.user.Id,
                FirstName = i.user.FirstName,
                LastName = i.user.LastName,


            }).AsQueryable();

            sumpage = (int)Math.Ceiling((double)result.Count()/3);

            if (!string.IsNullOrWhiteSpace(search))
            {
                result = result.Where(i => i.FirstName.Contains(search) || i.LastName.Contains(search));
                sumpage = (int)Math.Ceiling((double)result.Count() / 3);
            }

            result = result.Skip((activepage - 1) * 3).Take(3);

            return result.ToList();
        }
    }
}
