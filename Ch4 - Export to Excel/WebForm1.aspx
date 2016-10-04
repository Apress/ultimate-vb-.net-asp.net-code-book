<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Export_to_Excel.WebForm1"%>
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
			<asp:DataGrid id=MyDataGrid style="Z-INDEX: 101; LEFT: 27px; POSITION: absolute; TOP: 23px" runat="server" DataSource="<%# MyDataSet %>" DataMember="publishers" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="pub_name" HeaderText="Publisher Name"></asp:BoundColumn>
					<asp:BoundColumn DataField="city" HeaderText="City"></asp:BoundColumn>
					<asp:BoundColumn DataField="state" HeaderText="State"></asp:BoundColumn>
					<asp:BoundColumn DataField="country" HeaderText="Country"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
