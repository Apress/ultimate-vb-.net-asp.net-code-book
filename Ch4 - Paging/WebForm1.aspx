<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Paging.WebForm1"%>
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
			<asp:DataGrid id="MyDataGrid" style="Z-INDEX: 101; LEFT: 31px; POSITION: absolute; TOP: 33px" runat="server" BorderColor="Tan" BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" ForeColor="Black" PageSize="3" AllowPaging="True" DataSource="<%# MyDataSet %>" DataMember="publishers">
				<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
				<FooterStyle BackColor="Tan"></FooterStyle>
				<PagerStyle NextPageText="Next &gt;" PrevPageText="&lt; Back" HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
