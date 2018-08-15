using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yhtx.EntityModel;

namespace Yhtx.DAO.EFBase
{
    public abstract class EFOperate<T>
    {
        protected int result = 0;
        protected DataAccess context = new DataAccess();
        public virtual int Add(T model) { return result; }
        public virtual int AddRange(List<T> models) { return result; }
        public virtual int Update(T model) { return result; }
        public virtual int Delete(string id) { return result; }
    }
}
