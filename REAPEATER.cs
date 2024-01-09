<table border =2>
<asp:Repeater ID="Repeater1" runat="server"
DataSourceID="SqlDataSource1">
<HeaderTemplate >
<tr ><td style ="background-color:Lime ;">ROLL NO</td>
<td style ="background-color:Lime ;">NAME</td></tr>
</HeaderTemplate>
<ItemTemplate >
<tr><td><%#Eval("rno") %></td>
<td><%#Eval("name") %></td></tr></ItemTemplate>
<AlternatingItemTemplate >
<tr><td style ="background-color :Gray ;"><%#Eval("rno") %></td>
<td style ="background-color :Gray;"><%#Eval("name")%> </td></tr>
</AlternatingItemTemplate>
</asp:Repeater> </table>