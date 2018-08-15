using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.UserVM;
using Yhtx.EntityModel;
using Yhtx.EntityModel.QueryArgs;
using Yhtx.ViewModel;
using Yhtx.ViewModel.UserVM;
using Common.Utilities;
using Yhtx.EntityModel.Base;

namespace YhtxWeb.Controllers
{
    public class UnitController : Controller
    {
        UnitVM unitVM = new UnitVM();

        // GET: Unit
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Query()
        {
            return View();
        }
        public JsonResult QueryList(int pageIndex, int pageSize)
        {
            UserArgs userArgs = new UserArgs();
            var list = unitVM.QueryList(pageIndex, pageSize, true, userArgs);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetTree(string id)
        {
            List<T_UNIT> listUnit = unitVM.GetListAll();
            List<Tree> twoTreeList = new List<Tree>();
            T_UNIT _UNIT = listUnit.Where(x => string.IsNullOrEmpty(x.S_PARENT)).ToList().FirstOrDefault();
            Tree tree = new Tree() { id = _UNIT.S_ID, label = _UNIT.S_DESCRIPTION };
            List<T_UNIT> twoList = listUnit.Where(x => x.S_PARENT == tree.id).ToList();
            twoList.ForEach(x =>
            {
                List<Tree> threeTreeList = new List<Tree>();
                List<T_UNIT> threeList = listUnit.Where(y => y.S_ID == x.S_PARENT).ToList();
                if (threeList.Count > 0 && threeList != null)
                {
                    threeList.ForEach(z => { Tree tree3 = new Tree() { id = z.S_ID, label = z.S_DESCRIPTION }; threeTreeList.Add(tree3); });
                }
                Tree twoTree = new Tree() { id = x.S_ID, label = x.S_DESCRIPTION, children = threeTreeList };
                twoTreeList.Add(twoTree);
            });
            List<Tree> list = new List<Tree>();
            tree.children = twoTreeList;
            list.Add(tree);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}