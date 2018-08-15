using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yhtx.DAO.EFBase;
using Yhtx.EntityModel;
using Yhtx.EntityModel.Base;
using Yhtx.EntityModel.QueryArgs;
namespace Yhtx.DAO
{
   public class RoleOperate : EFOperate<T_ROLE>
    {
        public override int Add(T_ROLE model)
        {
            context.T_ROLE.Add(model);
            result = context.SaveChanges();
            return result;
        }
        public List<T_ROLE> GetListAll()
        {
            List<T_ROLE> list = context.T_ROLE.ToList();
            return list;
        }
    }
}
