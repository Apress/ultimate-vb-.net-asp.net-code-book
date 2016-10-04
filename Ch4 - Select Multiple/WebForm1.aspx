<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Select_Multiple.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Selecting Multiple Web Form Grid Items, Hotmail-Style</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id=MyDataGrid style="Z-INDEX: 101; LEFT: 33px; POSITION: absolute; TOP: 62px" runat="server" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" GridLines="Horizontal" ForeColor="Black" DataSource="<%# DataSet11 %>" DataMember="publishers">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CC3333"></SelectedItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#333333"></HeaderStyle>
				<FooterStyle ForeColor="Black" BackColor="#CCCC99"></FooterStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="Select">
						<ItemTemplate>
							<asp:CheckBox id="chkSelect" runat="server"></asp:CheckBox>
						</ItemTemplate>
					</asp:TemplateColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="White"></PagerStyle>
			</asp:DataGrid>
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 30px; POSITION: absolute; TOP: 22px" runat="server" Text="Delete (etc)" Width="121px" Height="28px"></asp:Button>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 103; LEFT: 172px; POSITION: absolute; TOP: 21px" runat="server" Width="355px" Height="28px"></asp:TextBox>
		</form>
	</body>
</HTML>
