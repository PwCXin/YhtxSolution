using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yhtx.EntityModel;
using Yhtx.ViewModel.UserVM;
using YhtxWeb.CommonAttribute;

namespace YhtxWeb.Controllers
{

    public class HomeController : BaseController
    {
        [Yhtx.ViewModel.UserVM.Authorize(RegistrationRole.Admin)]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult NoAuthorize()
        {
            return View();
        }
        public ActionResult ToDo()
        {
            return View();
        }
    }
}