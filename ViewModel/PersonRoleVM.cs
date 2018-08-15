using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yhtx.DAO;
using Yhtx.EntityModel;

namespace Yhtx.ViewModel
{
    public class PersonRoleVM
    {
        PersonRoleOperate _PersonRoleOperate;
        public PersonRoleVM()
        {
            _PersonRoleOperate = new PersonRoleOperate();
        }
        public int Add(T_Person_Role model)
        {
            return _PersonRoleOperate.Add(model);
        }
        public List<T_Person_Role> GetListAll()
        {
            return _PersonRoleOperate.GetListAll();
        }
        public int Delete(T_Person_Role model)
        {
            return _PersonRoleOperate.DeleteModel(model);
        }
    }
}
