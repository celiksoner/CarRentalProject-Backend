using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Entities.Concrete.User;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}