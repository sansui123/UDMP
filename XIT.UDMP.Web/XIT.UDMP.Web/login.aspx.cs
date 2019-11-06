using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XIT.UDMP.Web.BLL;

namespace XIT.UDMP.Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string LogNum = user.Text;
            string LogPwd = password.Text;
            LoginBll bll = new LoginBll();
            object result = bll.LogIn(LogNum, LogPwd);
            int num = Convert.ToInt32(result);

            if (result == null)
            {
                Response.Write("<script>alert('用户名密码错误,请重新输入！')</script>");
            }
            else
            {
                Session.Add("LogID", num);
                Response.Redirect("Index.aspx");
            }
        }
    }
}