using AutoMapper;
using Business_Tracking.DTOs.DTOs;
using Business_Tracking.DTOs.DTOs.AppUserDto;
using Business_Tracking.DTOs.DTOs.JobsDto;
using Business_Tracking.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Tracking.UI.Mapping.AutoMappingProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Urgency, UrgencyAddUpdateDto>();
            CreateMap<UrgencyAddUpdateDto, Urgency>();

            CreateMap<Jobs, JobsAddUpdateDto>();
            CreateMap<JobsAddUpdateDto, Jobs>();

            CreateMap<Jobs, JobsListDto>();
            CreateMap<JobsListDto, Jobs>();

            CreateMap<AppUser, AppUserRegisterDto>();
            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();
            CreateMap<AppUserLoginDto, AppUser>();
        }


    }
}
