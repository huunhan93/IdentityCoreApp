using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using IdentityCoreApp.Application.ViewModels.Common;
using IdentityCoreApp.Application.ViewModels.System;
using IdentityCoreApp.Data.Entities;

namespace IdentityCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
           
            CreateMap<Function, FunctionViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
            
            CreateMap<Footer, FooterViewModel>().MaxDepth(2);

            CreateMap<Feedback, FeedbackViewModel>().MaxDepth(2);
            CreateMap<Contact, ContactViewModel>().MaxDepth(2);

        }
    }
}
