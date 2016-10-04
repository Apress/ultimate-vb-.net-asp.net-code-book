<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Confirm_Deletes.WebForm1"%>
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
			<asp:DataGrid id=DataGrid1 style="Z-INDEX: 101; LEFT: 17px; POSITION: absolute; TOP: 50px" runat="server" BorderColor="#DEBA84" BorderStyle="None" CellSpacing="2" BorderWidth="1px" BackColor="#DEBA84" CellPadding="3" DataSource="<%# DataSet11 %>" DataMember="publishers" DataKeyField="pub_id">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="Delete" ButtonType="PushButton" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Label id="lblInfo" style="Z-INDEX: 102; LEFT: 23px; POSITION: absolute; TOP: 19px" runat="server"></asp:Label>
		</form>
	</body>
</HTML>
