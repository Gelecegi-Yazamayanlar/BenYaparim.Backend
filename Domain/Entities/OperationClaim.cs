using Core.Entities;

namespace Domain.Entities
{
    public class OperationClaim : BaseOperationClaim
    {
        public virtual List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
