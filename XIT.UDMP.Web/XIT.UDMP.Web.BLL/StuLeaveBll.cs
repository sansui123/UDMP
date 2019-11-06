using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIT.UDMP.Web.Model;
using XIT.UDMP.Web.DAL;

namespace XIT.UDMP.Web.BLL
{
   public class StuLeaveBll
    {
        StuLeaveDal dal = new StuLeaveDal();
        /// <summary>
        /// 查询数据库数据/列表查询
        /// </summary>
        public List<StuLeaveModel> GetUserList(string LeaName, int LeaState)
        {
            return dal.GetUserList(LeaName, LeaState);
        }
   }
}
