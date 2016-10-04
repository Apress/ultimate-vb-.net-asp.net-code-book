<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Drop_Down_in_Web_Grid.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id=MyDataGrid style="Z-INDEX: 101; LEFT: 23px; POSITION: absolute; TOP: 25px" runat="server" BorderColor="#999999" BorderStyle="Solid" CellSpacing="2" BorderWidth="3px" BackColor="#CCCCCC" CellPadding="4" ForeColor="Black" DataSource="<%# MyDataSet %>" DataKeyField="emp_id" DataMember="employee" AutoGenerateColumns="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
				<ItemStyle BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
				<FooterStyle BackColor="#CCCCCC"></FooterStyle>
				<Columns>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
					<asp:BoundColumn Visible="False" DataField="emp_id" SortExpression="emp_id" HeaderText="emp_id"></asp:BoundColumn>
					<asp:BoundColumn DataField="fname" SortExpression="fname" HeaderText="fname"></asp:BoundColumn>
					<asp:BoundColumn DataField="minit" SortExpression="minit" HeaderText="minit"></asp:BoundColumn>
					<asp:BoundColumn DataField="lname" SortExpression="lname" HeaderText="lname"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="job_id" SortExpression="job_id" HeaderText="job_id"></asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Job Type">
						<ItemTemplate>
							<asp:DropDownList id=ddl1 runat="server" DataMember="jobs" DataSource="<%# MyDataSet %>" DataValueField="job_id" DataTextField="job_desc" Enabled="False">
							</asp:DropDownList>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:DropDownList id=ddl2 runat="server" DataMember="jobs" DataSource="<%# MyDataSet %>" DataValueField="job_id" DataTextField="job_desc">
							</asp:DropDownList>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="job_lvl" SortExpression="job_lvl" HeaderText="job_lvl"></asp:BoundColumn>
					<asp:BoundColumn DataField="pub_id" SortExpression="pub_id" HeaderText="pub_id"></asp:BoundColumn>
					<asp:BoundColumn DataField="hire_date" SortExpression="hire_date" HeaderText="hire_date"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="Black" BackColor="#CCCCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
