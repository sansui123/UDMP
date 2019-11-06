using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIT.UDMP.Web.Model;
using XIT.UDMP.Web.DAL;

namespace XIT.UDMP.Web.BLL
{
    public class LoginBll
    {
        LoginDal dal = new LoginDal();
        /// <summary>
        /// 登录查询
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public object LogIn(string LogNum, string LogPwd)
        {
            return dal.LogIn(LogNum, LogPwd);
        }
    }
}
