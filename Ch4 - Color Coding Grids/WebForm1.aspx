<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Color_Coding_Grids.WebForm1"%>
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
			<asp:DataGrid id=DataGrid1 style="Z-INDEX: 101; LEFT: 35px; POSITION: absolute; TOP: 28px" runat="server" DataSource="<%# DataSet11 %>" DataMember="jobs" DataKeyField="job_id" BorderColor="White" BorderStyle="Ridge" CellSpacing="1" BorderWidth="2px" BackColor="White" CellPadding="3" GridLines="None">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
				<ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
				<FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
