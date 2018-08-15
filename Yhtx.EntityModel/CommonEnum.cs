using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhtx.EntityModel
{
    /// <summary>
    /// 判断是否有角色进入方法
    /// </summary>
    public enum RoleAccessEnum
    {
        Normal,
        AppAdmin,
        FINAdmin
    }
    public enum RegistrationRole
    {
        Admin,
        RegionAdmin,
        GeneralUser
    }
    public class Keys
    {
        public const string ADMIN = "Admin";
        public const string REGION_ADMIN = "RegionAdmin";
        public const string GENERAL_USER = "GeneralUser";
    }
}
