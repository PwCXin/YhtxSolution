using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yhtx.EntityModel;

namespace Yhtx.ViewModel.UserVM
{
    /// <summary>
    /// Define which role can visit this page
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class AuthorizeAttribute : FilterAttribute, IAuthorizationFilter
    {
        public RegistrationRole VisitRole { get; set; }

        /// <summary>
        /// which role allow to visit
        /// </summary>
        /// <param name="role">RegistrationRole</param>
        public AuthorizeAttribute(RegistrationRole role)
        {
            this.VisitRole = role;
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {

        }
    }
}