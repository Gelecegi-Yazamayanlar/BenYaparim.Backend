using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Domain.Entities;
using Application.Features.Admin.Commands.Role;
using Core.Application.Pipelines.Authorization;

namespace Application.Features.Admin.Queries.GetAll
{
    public class GetAllOperationClaimQuery : IRequest<GetAllOperationClaimQueryResponse>, ISecuredRequest
    {
        public string[] RequiredRoles => ["Admin"];

        public class GetAllOperationClaimQueryHandler : IRequestHandler<GetAllOperationClaimQuery, GetAllOperationClaimQueryResponse>
        {
            private readonly IOperationClaimRepository _operationClaimRepository;

            public GetAllOperationClaimQueryHandler(IOperationClaimRepository operationClaimRepository)
            {
                _operationClaimRepository = operationClaimRepository;
            }

            public async Task<GetAllOperationClaimQueryResponse> Handle(GetAllOperationClaimQuery request, CancellationToken cancellationToken)
            {
                List<OperationClaim>? _operationClaimsFromRepo = await _operationClaimRepository.GetListAsync();
                GetAllOperationClaimQueryResponse response = new() { operationClaims = _operationClaimsFromRepo };
                return response;
            }
        }
    }
}
