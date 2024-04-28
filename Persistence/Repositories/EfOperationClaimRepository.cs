using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class EfOperationClaimRepository : EfRepositoryBase<OperationClaim, BenYaparimDbContext>, IOperationClaimRepository
    {
        public EfOperationClaimRepository(BenYaparimDbContext context) : base(context)
        {
        }
    }
}
