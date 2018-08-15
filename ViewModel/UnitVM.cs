using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yhtx.DAO;
using Yhtx.EntityModel;
using Yhtx.EntityModel.Base;
using Yhtx.EntityModel.QueryArgs;

namespace Yhtx.ViewModel
{
    public class UnitVM
    {
        UnitOperate _UnitOperate;
        public UnitVM()
        {
            _UnitOperate = new UnitOperate();
        }
        public List<T_UNIT> GetListAll()
        {
            return _UnitOperate.GetListAll();
        }
        public Page<T_UNIT> QueryList(int pageIndex, int pageSize, bool isAsc, UserArgs args)
        {
            return _UnitOperate.QueryList(pageIndex,pageSize,isAsc,args);
        }
    }
}
