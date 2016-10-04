<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Click_Anywhere.WebForm1"%>
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
			<asp:DataGrid id=MyDataGrid style="Z-INDEX: 101; LEFT: 31px; POSITION: absolute; TOP: 61px" runat="server" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" DataSource="<%# DataSet11 %>" DataMember="publishers">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="&gt;" ButtonType="PushButton" HeaderText="Select" CommandName="Select"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 102; LEFT: 34px; POSITION: absolute; TOP: 20px" runat="server" Width="408px" Height="24px"></asp:TextBox>
		</form>
	</body>
</HTML>
