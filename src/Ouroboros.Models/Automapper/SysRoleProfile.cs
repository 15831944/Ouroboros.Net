using AutoMapper;
using Ouroboros.Entities;
using Ouroboros.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.Models.Automapper
{
    public class SysRoleProfile : Profile
    {

        public SysRoleProfile()
        {

            CreateMap<SysRoleViewModel, SysRole>();

            //CreateMap<User, UserData>()
            //    .ForMember(a => a.Id, t => t.MapFrom(b => b.Id))
            //    .ForMember(a => a.RoleName, t => t.MapFrom(b => b.Role.Name))
            //    .ForMember(a => a.RoleDisplayName, t => t.MapFrom(b => b.Role.DisplayName))
            //    .ForMember(a => a.MainDepartmentId, t => t.MapFrom(b => b.UserDepartments.First(x => x.IsMainDepartment == true).Department.Id))
            //    .ForMember(a => a.MainDepartmentDisplayName, t => t.MapFrom(b => b.UserDepartments.First(x => x.IsMainDepartment == true).Department.GetDisplayName()))
            //    ;

        }

    }
}
