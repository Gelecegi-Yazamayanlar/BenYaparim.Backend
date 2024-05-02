using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Domain.Entities;
using Application.Features.Admin.Commands.Role;

namespace Application.Features.Admin
{
    public class GetAllOperationClaimQueryResponse : IRequest<GetAllOperationClaimQueryResponse>
    {
        public List<OperationClaim> operationClaims { get; set; }
    }
}
