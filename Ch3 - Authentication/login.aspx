<%@ Page Language="vb" AutoEventWireup="false" Codebehind="login.aspx.vb" Inherits="Ch3___Authentication.login"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>login</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 19px" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium">Login Example</asp:Label>
			<asp:TextBox id="txtPassword" style="Z-INDEX: 106; LEFT: 170px; POSITION: absolute; TOP: 132px" runat="server" Width="155px" TextMode="Password"></asp:TextBox>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 85px; POSITION: absolute; TOP: 136px" runat="server">Password</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 28px; POSITION: absolute; TOP: 53px" runat="server">Use "test1" and "password" as your credentials.</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 84px; POSITION: absolute; TOP: 103px" runat="server">Username</asp:Label>
			<asp:TextBox id="txtUsername" style="Z-INDEX: 105; LEFT: 170px; POSITION: absolute; TOP: 103px" runat="server"></asp:TextBox>
			<asp:CheckBox id="chkPersist" style="Z-INDEX: 107; LEFT: 169px; POSITION: absolute; TOP: 176px" runat="server" Text="Remember me"></asp:CheckBox>
			<asp:Button id="Button1" style="Z-INDEX: 108; LEFT: 364px; POSITION: absolute; TOP: 220px" runat="server" Text="Login"></asp:Button>
			<asp:Label id="lblError" style="Z-INDEX: 109; LEFT: 96px; POSITION: absolute; TOP: 227px" runat="server" Font-Bold="True" Width="242px" ForeColor="#C00000" Height="62px"></asp:Label>
		</form>
	</body>
</HTML>
