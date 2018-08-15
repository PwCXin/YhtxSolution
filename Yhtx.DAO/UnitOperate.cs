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
   public class UnitOperate : EFOperate<T_UNIT>
    {
        public override int Add(T_UNIT model)
        {
            context.T_UNIT.Add(model);
            result = context.SaveChanges();
            return result;
        }
        public List<T_UNIT> GetListAll()
        {
            List<T_UNIT> list = context.T_UNIT.ToList();
            return list;
        }
        public Page<T_UNIT> QueryList(int pageIndex, int pageSize, bool isAsc, UserArgs args)
        {
            Page<T_UNIT> result = new Page<T_UNIT>();
            result.Count = context.T_PERSON.Count();
            List<T_UNIT> list = context.T_UNIT.OrderByDescending(x => x.S_ID).Skip(((pageIndex - 1) * pageSize)).Take(pageSize).Select(s => s).ToList();
            result._PageList = list;
            return result;
        }
    }
}
