using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable tempTable = new DataTable();

        tempTable.Columns.Add("ID");
        tempTable.Columns.Add("NAME");

        DataRow newrow = tempTable.NewRow();
        newrow[0] = 0;
        newrow[1] = "Avinash";
        tempTable.Rows.Add(newrow);

        newrow = tempTable.NewRow();
        newrow[0] = 1;
        newrow[1] = "Kavita";
        tempTable.Rows.Add(newrow);

        Response.Write("Original Table"+"<br>");
        for (int i = 0; i < tempTable.Rows.Count; i++)
        {
            Response.Write(tempTable.Rows[i][0].ToString() + "--->" + tempTable.Rows[i][1].ToString()+"<br>");
        }

        Response.Write("Modified Table" + "<br>");
        for (int i = 0; i < tempTable.Rows.Count; i++)
        {
            if (tempTable.Rows[i][1].ToString() == "Kavita")
            {
                tempTable.Rows[i][1] = "Ganesh";
            }
        Response.Write(tempTable.Rows[i][0].ToString() + "--->" + tempTable.Rows[i][1].ToString() + "<br>");
        }



        Response.Write("After Deleting row from Table" + "<br>");
        for (int i = 0; i < tempTable.Rows.Count; i++)
        {
            if (tempTable.Rows[i][1].ToString() == "Ganesh")
            {
                tempTable.Rows[i].Delete();
            }
        }
        for (int i = 0; i < tempTable.Rows.Count; i++)
        {
            Response.Write(tempTable.Rows[i][0].ToString() + "--->" + tempTable.Rows[i][1].ToString() + "<br>");
        }
     }
 }
