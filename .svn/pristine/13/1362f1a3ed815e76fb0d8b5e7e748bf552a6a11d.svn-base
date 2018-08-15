using ApplicationCenter.ClientClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Yhtx.EntityModel;

namespace Yhtx.ViewModel.UserVM
{
    public class UserToolUtil
    {
        /// <summary>
        /// Gets user name
        /// </summary>
        public string StaffName
        {
            get { return HttpContext.Current.Items["UserName"].ToString(); }
        }

        /// <summary>
        /// Gets staff id
        /// </summary>
        public string StaffID
        {
            get { return HttpContext.Current.User.Identity.Name; }
        }

        /// <summary>
        /// Gets current user roles type
        /// </summary>
        public IEnumerable<string> CurrentRole
        {
            get
            {
                return new ApplicationCenter.ClientClass.WebUser().GetUserRoles();
            }
        }

        public bool Admin()
        {
            return new WebUser().GetUserRoles().Contains(Keys.ADMIN);
        }
    }
}
