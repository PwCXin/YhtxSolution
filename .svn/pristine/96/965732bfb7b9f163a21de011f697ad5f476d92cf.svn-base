using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yhtx.EntityModel;
using Yhtx.ViewModel.UserVM;

namespace YhtxWeb.Controllers
{
    [HandleError]
    public class BaseController : Controller
    {
        protected UserToolUtil user = new UserToolUtil();
        #region OnAuthorization
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            //For Anonymous Action
            if (filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), false)
                ||
                filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(HandleErrorAttribute), false)
                || filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), false))
            {
                return;
            }

            //For Child Action
            if (filterContext.ActionDescriptor.IsDefined(typeof(ChildActionOnlyAttribute), false))
            {
                return;
            }
            List<string> roles = user.CurrentRole.ToList();

            if (roles.Contains(Keys.ADMIN))
            {
                return;
            }

            bool hasPermission = false;

            if (filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), false) ||
                filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(Yhtx.ViewModel.UserVM.AuthorizeAttribute), false) ||
                filterContext.ActionDescriptor.IsDefined(typeof(Yhtx.ViewModel.UserVM.AuthorizeAttribute), false))
            {
                IEnumerable<FilterAttribute> filters = filterContext.ActionDescriptor.ControllerDescriptor.GetFilterAttributes(false);
                if (filters.Count() == 1 && (filters.First() is HandleErrorAttribute))
                {
                    filters = filterContext.ActionDescriptor.GetFilterAttributes(false); //Get Action Attributes
                }
                foreach (var attr in filters)
                {
                    if (attr is Yhtx.ViewModel.UserVM.AuthorizeAttribute)
                    {
                        Yhtx.ViewModel.UserVM.AuthorizeAttribute auth = attr as Yhtx.ViewModel.UserVM.AuthorizeAttribute;
                        if (roles.Contains(auth.VisitRole.ToString()))
                        {
                            hasPermission = true;
                            break;
                        }
                    }
                }
            }

            if (!hasPermission)
            {
                filterContext.Result = RedirectToAction("NoAuthorize", "Home");
            }
        }
        #endregion
    }
}