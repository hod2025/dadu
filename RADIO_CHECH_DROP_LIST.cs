using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
public partial class _Default : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
}
protected void Button1_Click(object sender, EventArgs e)
{
Label1.Text = DropDownList1.SelectedValue.ToString();
Label2.Text = "Selected Item(s):<br /><br />";
for (int i = 0; i < CheckBoxList2.Items.Count; i++)
{
if (CheckBoxList2.Items[i].Selected)
{
Label2.Text += CheckBoxList2.Items[i].Text + "<br />";
}
}
Label3.Text = "Selected Item(s):<br /><br />";
for (int i = 0; i < RadioButtonList1.Items.Count; i++)
{
if (RadioButtonList1.Items[i].Selected)
{
Label3.Text += RadioButtonList1.Items[i].Text + "<br />";
}
}
}
}