using AutoMapper;
using snowball.API.Contracts.UserProfile.Requests;
using snowball.API.Contracts.UserProfile.Responses;
using snowball.Application.UserProfiles.Commands;
using snowball.Domain.Aggregates.UserProfileAggregate;

namespace snowball.API.MappingProfiles
{
    internal class UserProfileMappings : Profile
    {
        public UserProfileMappings() 
        {
            CreateMap<UserProfileCreateUpdate, CreateUserCommand>();
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfoCommand>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
        }
    }
}
