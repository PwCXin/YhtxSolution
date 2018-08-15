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

namespace YhtxWeb.Controllers
{
    public class PersonController : Controller
    {
        UserVM userVM = new UserVM();
        UnitVM unitVM = new UnitVM();
        RoleVM roleVM = new RoleVM();
        CateGoryVM cateGoryVM = new CateGoryVM();
        PersonRoleVM personRoleVM = new PersonRoleVM();
        // GET: Person
        public ActionResult Query()
        {
            return View();
        }
        public JsonResult QueryList(int pageIndex, int pageSize)
        {
            UserArgs userArgs = new UserArgs();
            var list = userVM.QueryList(pageIndex, pageSize, true, userArgs);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetUnitAll()
        {
            List<T_UNIT> list = unitVM.GetListAll();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetRoleAll()
        {
            List<T_ROLE> list = roleVM.GetListAll();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCateGoryByScope(string scope)
        {
            List<T_CATEGORY> list = cateGoryVM.GetCateGoryByScope(scope);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public int PersonAdd(string person, string Role)
        {
            T_PERSON user = JSONHelper.FromJson<T_PERSON>(person);
            int result = 0;
            try
            {
                if (!string.IsNullOrEmpty(Role))
                {
                    var arr = Role.Split(',');
                    foreach (var item in arr)
                    {
                        T_Person_Role _personRole = new T_Person_Role();
                        _personRole.S_Id = Common.Utilities.UniqueNumber.GuidNumber();
                        _personRole.S_PERSONID = user.S_POLICENUM;
                        _personRole.S_ROLE_ID = item;
                        _personRole.D_UPDATETIME = DateTime.Now;
                        personRoleVM.Add(_personRole);
                    }
                }
                result = userVM.Add(user);
                result = 1;
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        public int Update(string person, string Role)
        {
            T_PERSON user = JSONHelper.FromJson<T_PERSON>(person);
            int result = 0;
            try
            {
               var list = personRoleVM.GetListAll().Where(x => x.S_PERSONID == user.S_ID).ToList();
                if (list != null && list.Count > 0)
                    list.ForEach(x => personRoleVM.Delete(x));
                
                if (!string.IsNullOrEmpty(Role))
                {
                    var arr = Role.Split(',');
                    foreach (var item in arr)
                    {
                        T_Person_Role _personRole = new T_Person_Role();
                        _personRole.S_Id = Common.Utilities.UniqueNumber.GuidNumber();
                        _personRole.S_PERSONID = user.S_POLICENUM;
                        _personRole.S_ROLE_ID = item;
                        _personRole.D_UPDATETIME = DateTime.Now;
                        personRoleVM.Add(_personRole);
                    }
                }
                result = userVM.Update(user);
                result = 1;
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        public int Delete(string id)
        {
            int result = 0;
            userVM.Delete(id);
            var list = personRoleVM.GetListAll().Where(x => x.S_PERSONID == id).ToList();
            if (list != null && list.Count > 0)
                list.ForEach(x => personRoleVM.Delete(x));
            return result;
        }
    }
}