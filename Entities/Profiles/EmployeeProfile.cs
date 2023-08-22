using AutoMapper;
using automapper_example.ViewModels;

namespace automapper_example.Entities.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(
                    r => r.FirstName,
                    opt => opt.MapFrom(x => x.Name.FirstName))
                .ForMember(
                    r => r.LastName,
                    opt => opt.MapFrom(x => x.Name.LastName))
                .ForMember(
                    r => r.DepartmentName,
                    opt => opt.MapFrom(x => x.Department.Name));
        }
    }
}
