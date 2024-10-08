using AutoMapper;
using OnlineEdu.DTO.DTOs.TeacherSocialDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
	public class TeacherSocialMapping : Profile
	{
		public TeacherSocialMapping()
		{
			CreateMap<CreateTeacherSocialDto, TeacherSocial>().ReverseMap();
			CreateMap<UpdateTeacherSocialDto, TeacherSocial>().ReverseMap();
			CreateMap<ResultTeacherSocialDto, TeacherSocial>().ReverseMap();
		}
	}
}
