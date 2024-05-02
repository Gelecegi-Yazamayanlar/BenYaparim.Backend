using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;

namespace Application.Features.Admin.Commands.Role
{
    public class AddOperationClaimCommand : IRequest<AddOperationClaimResponse>, ISecuredRequest
    {
        public string Name { get; set; }

        public string[] RequiredRoles => ["Admin"];

        public class AddOperationClaimCommandHandler : IRequestHandler<AddOperationClaimCommand, AddOperationClaimResponse>
        {
            private readonly IOperationClaimRepository _operationClaimRepository;
            private readonly IMapper _mapper;

            public AddOperationClaimCommandHandler(IOperationClaimRepository operationClaimRepository, IMapper mapper)
            {
                _operationClaimRepository = operationClaimRepository;
                _mapper = mapper;
            }

            public async Task<AddOperationClaimResponse> Handle(AddOperationClaimCommand request, CancellationToken cancellationToken)
            {
                OperationClaim? productWithSameName = await _operationClaimRepository.GetAsync(p => p.Name == request.Name);
                if (productWithSameName is not null)
                    throw new BusinessException("Aynı isimde 2. rol eklenemez.");


                OperationClaim operationClaim = _mapper.Map<OperationClaim>(request);
                await _operationClaimRepository.AddAsync(operationClaim);

                AddOperationClaimResponse response = _mapper.Map<AddOperationClaimResponse>(operationClaim);
                return response;
            }
        }
    }
}
