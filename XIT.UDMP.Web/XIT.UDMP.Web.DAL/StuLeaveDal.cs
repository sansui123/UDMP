using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using XIT.UDMP.Web.Model;
using System.Data.SqlClient;

namespace XIT.UDMP.Web.DAL
{
    public class StuLeaveDal
    {
        /// <summary>
        /// 查询数据库数据/列表查询
        /// </summary>
        public List<StuLeaveModel> GetUserList(string LeaName, int LeaState)
        {
            string str = @"select * from  StuLeave,StuInfo where StuInfo.StuID=StuLeave.StuID";
            List<SqlParameter> sqlpar = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(LeaName))
            {
                str += " and LeaName = @LeaName";
                sqlpar.Add(new SqlParameter("@LeaName", LeaName));
            }
            if (LeaState==2)
            {
                str += " and 1=1";
            }
            else if(!string.IsNullOrEmpty(Convert.ToString(LeaState)))
            {
                str += " and LeaState=@LeaState";
                sqlpar.Add(new SqlParameter("@LeaState", LeaState));
            }
            SqlDataReader reader = DBHelper.ExcuteSqlDataReader(str, sqlpar.ToArray());
            List<StuLeaveModel> list = new List<StuLeaveModel>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StuLeaveModel model = new StuLeaveModel();
                    model.LeaID = int.Parse(reader["LeaID"].ToString());
                    model.StuID = int.Parse(reader["StuID"].ToString());
                    model.LeaName = reader["LeaName"].ToString();
                    model.LeaBegintime = Convert.ToDateTime(reader["LeaBegintime"]);
                    model.LeaEndtime = Convert.ToDateTime(reader["LeaEndtime"]);
                    model.LeaCause = reader["LeaCause"].ToString();
                    model.LeaState =Convert.ToInt32(reader["LeaState"]);
                    list.Add(model);
                }
            }

            return list;
        }
    }
}
