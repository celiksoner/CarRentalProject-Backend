using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DatabaseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using var context = new DatabaseContext();
            var result = from OperationClaim in context.OperationClaims
                         join UserOperationClaim in context.UserOperationClaims
                             on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                         where UserOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name };
            return result.ToList();
        }
    }
}