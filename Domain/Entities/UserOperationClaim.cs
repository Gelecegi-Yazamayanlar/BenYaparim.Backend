using Core.Entities;

namespace Domain.Entities
{
    public class UserOperationClaim : BaseUserOperationClaim
    {
        public virtual OperationClaim OperationClaim { get; set; }
        public virtual User User { get; set; }
    }
}
