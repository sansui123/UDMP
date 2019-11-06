using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XIT.UDMP.Web.BLL;
using XIT.UDMP.Web.Model;

namespace XIT.UDMP.Web
{
    public partial class StuLeave : System.Web.UI.Page
    {
        StuLeaveBll bll = new StuLeaveBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //绑定数据
                Bind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Bind();
        }
        public void Bind()
        {
            Repeater1.DataSource = bll.GetUserList(TextBox1.Text,Convert.ToInt32(RadioButtonList1.SelectedValue));
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}