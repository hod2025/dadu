using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("");
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            getdata();
    }
    void getdata()
    {
        SqlCommand cmd = new SqlCommand("select * from std", con);
        con.Open();
        dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("insert into Table5 values(" + Convert.ToInt32(TextBox1.Text) + ",'" + TextBox2.Text + "'," + Convert.ToInt32(TextBox3.Text) + ")", con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        getdata();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd2 = new SqlCommand("Update Table5 set name='" + TextBox2.Text + "',mark=" + Convert.ToInt32(TextBox3.Text) + "where rno=" + Convert.ToInt32(TextBox1.Text), con);
        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();
        getdata();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd3 = new SqlCommand("Delete from Table5 Where rno=" + Convert.ToInt32(TextBox1.Text), con);
        con.Open();
        cmd3.ExecuteNonQuery();
        con.Close();
        getdata();
    }
}
