1.Start->Programs->Visual studio 2008
2.Create new web site.
3. Take Label1, Button1
4. Write following code
protected void Button1_Click(object sender, EventArgs e)
{
Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;//Set Value to
The Session
Label1.Text = Session["Count"].ToString(); //Get Value from the Sesion
}
5. Take Label2, Button2, HiddentField1, Set HiddentField1.Value=0
6. Write following code
protected void Button2_Click(object sender, EventArgs e)
{
if (HiddenField1.Value != null)
{
try
{
int val = Convert.ToInt32(HiddenField1.Value) + 1;
HiddenField1.Value = val.ToString();
Label2.Text = val.ToString();
}
catch (Exception exc)
{
Response.Write(exc);
}
}
}