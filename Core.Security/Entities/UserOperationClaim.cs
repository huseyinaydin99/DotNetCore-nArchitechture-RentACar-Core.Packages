using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities;

public class UserOperationClaim : Entity<int>
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }
    public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }

    public UserOperationClaim(int userId, int operationClaimId, User user, OperationClaim operationClaim)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
        User = user;
        OperationClaim = operationClaim;
    }

    public UserOperationClaim(int id, int userId, int operationClaimId, User user, OperationClaim operationClaim) : base(id)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
        User = user;
        OperationClaim = operationClaim;
    }
}