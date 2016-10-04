<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch3___Move_List_Items.WebForm1"%>
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
			<asp:ListBox id="ListBox1" style="Z-INDEX: 100; LEFT: 35px; POSITION: absolute; TOP: 35px" runat="server" Width="202px" Height="121px">
				<asp:ListItem Value="Ken Strauss">Ken Strauss</asp:ListItem>
				<asp:ListItem Value="Lisa Root">Lisa Root</asp:ListItem>
				<asp:ListItem Value="Jamie Plenderleith">Jamie Plenderleith</asp:ListItem>
				<asp:ListItem Value="Mark Sandler">Mark Sandler</asp:ListItem>
				<asp:ListItem Value="Jackie Roberts">Jackie Roberts</asp:ListItem>
				<asp:ListItem Value="Katrina Bunker">Katrina Bunker</asp:ListItem>
			</asp:ListBox>
			<asp:Button id="Button2" style="Z-INDEX: 104; LEFT: 257px; POSITION: absolute; TOP: 108px" runat="server" Text="Move Down"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 35px; POSITION: absolute; TOP: 183px" runat="server">Click on the buttons to move items up and down in the list.</asp:Label>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 256px; POSITION: absolute; TOP: 47px" runat="server" Text="Move Up"></asp:Button>
		</form>
	</body>
</HTML>
