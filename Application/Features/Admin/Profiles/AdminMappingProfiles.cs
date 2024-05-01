using Application.Features.Admin.Commands.Role;
using Domain.Entities;
using AutoMapper;
using Application.Features.Admin.Queries.GetAll;

namespace Application.Features.Admin.Profiles
{
    public class AdminMappingProfiles : Profile
    {
        public AdminMappingProfiles()
        {
            CreateMap<OperationClaim, AddOperationClaimCommand>().ReverseMap();
            CreateMap<OperationClaim, AddOperationClaimResponse>().ReverseMap();
        }
    }
}
