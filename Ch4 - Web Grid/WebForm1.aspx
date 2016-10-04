<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch4___Web_Grid.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Nine Steps to a Quick, Editable Web Grid</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="MyDataGrid" style="Z-INDEX: 101; LEFT: 23px; POSITION: absolute; TOP: 64px" runat="server" BorderColor="White" BorderStyle="Ridge" CellSpacing="1" BorderWidth="2px" BackColor="White" CellPadding="3" GridLines="None">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
				<ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
				<FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="&gt;" ButtonType="PushButton" CommandName="Select"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
			</asp:DataGrid>
			<asp:Button id="Button6" style="Z-INDEX: 107; LEFT: 373px; POSITION: absolute; TOP: 20px" runat="server" Text="Update" Width="61" Height="25px"></asp:Button>
			<asp:Button id="Button5" style="Z-INDEX: 106; LEFT: 304px; POSITION: absolute; TOP: 20px" runat="server" Text="Cancel" Width="61" Height="25px"></asp:Button>
			<asp:Button id="Button4" style="Z-INDEX: 105; LEFT: 235px; POSITION: absolute; TOP: 20px" runat="server" Text="OK" Width="61" Height="25px"></asp:Button>
			<asp:Button id="Button3" style="Z-INDEX: 104; LEFT: 166px; POSITION: absolute; TOP: 20px" runat="server" Text="Edit" Width="61" Height="25px"></asp:Button>
			<asp:Button id="Button2" style="Z-INDEX: 103; LEFT: 97px; POSITION: absolute; TOP: 20px" runat="server" Text="Delete" Width="61" Height="25px"></asp:Button>
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 20px" runat="server" Text="Add" Width="61" Height="25px"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 108; LEFT: 495px; POSITION: absolute; TOP: 17px" runat="server" Height="27px" Width="171px">You may need to change the ConnectionString property of MyConnection before starting!</asp:Label>
		</form>
	</body>
</HTML>
