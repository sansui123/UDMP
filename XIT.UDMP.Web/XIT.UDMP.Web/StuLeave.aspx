<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuLeave.aspx.cs" Inherits="XIT.UDMP.Web.StuLeave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
           姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           审核状态：<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                 <asp:ListItem Value="0">未审批</asp:ListItem>
                 <asp:ListItem Value="1">已审批</asp:ListItem>
                 <asp:ListItem Value="2" Selected="True">全部</asp:ListItem>
             </asp:RadioButtonList>
             &nbsp;
             <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
             <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                 <HeaderTemplate>
                     <table>
                         <tr>
                             <th>学号</th>
                             <th>姓名</th>
                             <th>请假时间</th>
                             <th>请假结束时间</th>
                             <th>请假原因</th>
                             <th>审批状态</th>
                         </tr>
                 </HeaderTemplate>
                 <ItemTemplate>
                     <tr>
                         <td><%#Eval("StuID") %></td>
                         <td><%#Eval("LeaName") %></td>
                         <td><%#Eval("LeaBegintime") %></td>
                         <td><%#Eval("LeaEndtime") %></td>
                         <td><%#Eval("LeaCause") %></td>
                         <td><%#Eval("LeaState") %></td>
                         <td>
                             <asp:LinkButton ID="LinkButton1" runat="server" CommandName="update" CommandArgument='<%#Eval("LeaID") %>'>更新</asp:LinkButton>
                             <asp:LinkButton ID="LinkButton2" runat="server" CommandName="dalete" CommandArgument='<%#Eval("LeaID") %>'>删除</asp:LinkButton>
                             <asp:LinkButton ID="LinkButton3" runat="server" CommandName="insert" CommandArgument='<%#Eval("LeaID") %>'>注册</asp:LinkButton>
                         </td>
                     </tr>
                 </ItemTemplate>
                 <FooterTemplate>
                     </table>
                 </FooterTemplate>
             </asp:Repeater>
        </div>
    </form>
</body>
</html>
