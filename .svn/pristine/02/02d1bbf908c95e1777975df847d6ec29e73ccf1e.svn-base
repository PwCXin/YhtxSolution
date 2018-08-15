using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yhtx.DAO;
using Yhtx.EntityModel;

namespace Yhtx.ViewModel
{
    public class CateGoryVM
    {
        CateGoryOperate _CateGoryOperate;
        public CateGoryVM()
        {
            _CateGoryOperate = new CateGoryOperate();
        }
        public List<T_CATEGORY> GetListAll()
        {
            return _CateGoryOperate.GetListAll();
        }
        public List<T_CATEGORY> GetCateGoryByScope(string scope)
        {
            return _CateGoryOperate.GetCateGoryByScope(scope);
        }
    }
}
