using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhtx.ViewModel.UserVM
{
    public static class Utils
    {
        //判断用户是否为Admin角色
        public const string ADMIN = "Admin";
        private static string _appCode;
        public static string AppCode
        {
            get
            {
                if (string.IsNullOrEmpty(_appCode))
                {
                    _appCode = ConfigurationManager.AppSettings["appCode"];
                }
                return _appCode;
            }
        }
        private static string _appVersion;
        public static string AppVersion
        {
            get
            {
                if (string.IsNullOrEmpty(_appVersion))
                {
                    _appVersion = ConfigurationManager.AppSettings["AppVersion"];
                }
                return _appVersion;
            }
        }
    }
}
