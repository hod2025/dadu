Label1.Text = "Name :- " + TextBox8.Text;
Label1.Visible = true;
Label2.Text = "Password :- " + TextBox10.Text;
Label2. Visible = true;
Label3.Text = "Confirm Password :- " + TextBox11.Text;
Label3.Visible = true;
Label4.Text = "Age :- " + TextBox12.Text;
Label4.Visible = true;
Label5.Text = "Salary :- " + TextBox13.Text;
Label5.Visible = true;
Label6.Text = "Email :- " + TextBox6.Text;
Label6.Visible = true;
Label7.Text = "Address :- " + TextBox9.Text;
Label7.Visible = true;
if (RadioButton1.Checked)
{
Label8.Text = " Gender :- Male";
Label8.Visible = true;
}
else
{
Label8.Text = " Gender :- Female";
Label8.Visible = true;
}
if (CheckBox1.Checked)
{
Label9.Visible = true;
Label9.Text = "Known Language :- " + CheckBox1.Text;
}
if (CheckBox2.Checked)
{
Label9.Visible = true;
Label9.Text += "," + CheckBox2.Text;
}
string msg = "";
foreach (ListItem li in ListBox1.Items)
{
if (li.Selected == true)
{
msg += "<BR>" + li.Text + " is selected.";
}
}
Label10.Text = msg;