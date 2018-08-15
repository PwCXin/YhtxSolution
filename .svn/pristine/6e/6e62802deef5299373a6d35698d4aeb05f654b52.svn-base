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
   public class CateGoryOperate : EFOperate<T_CATEGORY>
    {
        public override int Add(T_CATEGORY model)
        {
            context.T_CATEGORY.Add(model);
            result = context.SaveChanges();
            return result;
        }
        public List<T_CATEGORY> GetListAll()
        {
            List<T_CATEGORY> list = context.T_CATEGORY.ToList();
            return list;
        }
        public List<T_CATEGORY> GetCateGoryByScope(string scope)
        {
            List<T_CATEGORY> list = context.T_CATEGORY.Where(x => x.S_SCOPE == scope).ToList();
            return list;
        }
    }
}
