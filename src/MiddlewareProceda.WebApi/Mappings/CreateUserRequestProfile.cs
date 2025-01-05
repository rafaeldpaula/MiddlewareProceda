using MiddlewareProceda.Application.Users.CreateUser;
using MiddlewareProceda.WebApi.Features.Users.CreateUser;
using AutoMapper;

namespace MiddlewareProceda.WebApi.Mappings;

public class CreateUserRequestProfile : Profile
{
    public CreateUserRequestProfile()
    {
        CreateMap<CreateUserRequest, CreateUserCommand>();
    }
}