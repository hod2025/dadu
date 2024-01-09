using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
public partial class _Default : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
SqlConnection con = new SqlConnection("");
DataTable ds = new DataTable();
16
SqlDataAdapter sde = new SqlDataAdapter("select * from student", con);
sde.Fill(ds);
GridView1.DataSource = ds;
GridView1.DataBind();
ArrayList list = new ArrayList();
list.Add("AAAA");
list.Add("BBBB");
list.Add("CCCC");
GridView2.DataSource =list;
GridView2.DataBind();
Hashtable hashItems = new Hashtable();
hashItems.Add("4","GGGG");
hashItems.Add("5","HHHH");
hashItems.Add("6","IIII");
hashItems.Add("7","JJJJ");
GridView3.DataSource = hashItems;
GridView3.DataBind();
}
}