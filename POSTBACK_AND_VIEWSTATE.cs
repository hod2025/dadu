//1. File-New Website
//2. Take 2 DropDownList2, 2nd having property //EnableViewState="false"
//3. Write Following Code

protected void Page_Load(object sender, EventArgs e)
{
bind1();
bind2();
}
public void bind1()
{
ListItem l1 = new ListItem("India");
ListItem l2 = new ListItem("US");
ListItem l3 = new ListItem("Japan");
DropDownList1.Items.Add(l1);
DropDownList1.Items.Add(l2);
DropDownList1.Items.Add(l3);
}
public void bind2()
{
ListItem l1 = new ListItem("India");
ListItem l2 = new ListItem("US");
ListItem l3 = new ListItem("Japan");
DropDownList2.Items.Add(l1);
DropDownList2.Items.Add(l2);
DropDownList2.Items.Add(l3);
}