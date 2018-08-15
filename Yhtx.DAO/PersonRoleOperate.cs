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
    public class PersonRoleOperate : EFOperate<T_Person_Role>
    {
        public override int Add(T_Person_Role model)
        {
            context.T_Person_Role.Add(model);
            result = context.SaveChanges();
            return result;
        }
        public List<T_Person_Role> GetListAll()
        {
            List<T_Person_Role> list = context.T_Person_Role.ToList();
            return list;
        }
        public  int DeleteModel(T_Person_Role model)
        {
            context.T_Person_Role.Remove(model);
            result = context.SaveChanges();
            return result;
        }
    }
}
