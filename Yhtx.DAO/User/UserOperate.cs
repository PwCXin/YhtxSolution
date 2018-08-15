using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yhtx.DAO.EFBase;
using Yhtx.EntityModel;
using Yhtx.EntityModel.Base;
using Yhtx.EntityModel.QueryArgs;

namespace Yhtx.DAO.User
{
    public class UserOperate : EFOperate<T_PERSON>
    {
        public override int Add(T_PERSON model)
        {
            context.T_PERSON.Add(model);
            result = context.SaveChanges();
            return result;
        }
        public override int AddRange(List<T_PERSON> model)
        {
            context.T_PERSON.AddRange(model);
            result = context.SaveChanges();
            return result;
        }
        public T_PERSON LoginInfo(string userId, string pwd)
        {
            //根据账号密码登录
            T_PERSON _PERSON = context.T_PERSON.Where(x => x.S_POLICENUM == userId && x.S_PASSWORD == pwd).ToList().FirstOrDefault();
            return _PERSON;
        }
        public Page<T_PERSON> QueryList(int pageIndex, int pageSize, bool isAsc, UserArgs args)
        {
            Page<T_PERSON> result = new Page<T_PERSON>();
            result.Count = context.T_PERSON.Count();
            List<T_PERSON> list = context.T_PERSON.OrderByDescending(x => x.S_ID).Skip(((pageIndex - 1) * pageSize)).Take(pageSize).Select(s => s).ToList();
            result._PageList = list;
            return result;
        }
        public override int Update(T_PERSON model)
        {
            context.T_PERSON.AddOrUpdate(model);
            return result = context.SaveChanges();
        }
        public override int Delete(string id)
        {
            T_PERSON t_PERSON = context.T_PERSON.Find(id);
            context.T_PERSON.Remove(t_PERSON);
            return result = context.SaveChanges();
        }
    }
}
