using AutoMapper;
using LeaveAndEmploymentWeb.Data;
using LeaveAndEmploymentWeb.Models;

namespace LeaveAndEmploymentWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
