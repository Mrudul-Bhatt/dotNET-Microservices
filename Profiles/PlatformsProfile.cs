using AutoMapper;
using dotNET_Microservices.DTO;
using dotNET_Microservices.Models;

namespace dotNET_Microservices.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target   

            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}