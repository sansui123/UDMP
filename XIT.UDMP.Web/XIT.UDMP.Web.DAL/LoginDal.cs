using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIT.UDMP.Web.DAL
{
    public class LoginDal
    {
        /// <summary>
        /// 登录/获取首行首列
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPwd">密码</param>
        /// <returns></returns>
        public object LogIn(string LogNum, string LogPwd)
        {
            string str = "SELECT * FROM [LoginInfo] where LogNum=@LogNum and LogPwd=@LogPwd ";

            SqlParameter[] sqlParameters = new SqlParameter[]
           {
                new SqlParameter("@LogNum", LogNum),
                new SqlParameter("@LogPwd", LogPwd)
           };
            object result = DBHelper.ExcuteScalar(str, sqlParameters);
            return result;
        }
    }
}
