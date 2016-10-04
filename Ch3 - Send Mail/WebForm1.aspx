<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch3___Send_Mail.WebForm1"%>
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
			<asp:Button id="Button1" style="Z-INDEX: 100; LEFT: 393px; POSITION: absolute; TOP: 338px" runat="server" Text="Send Message"></asp:Button>
			<asp:TextBox id="TextBox4" style="Z-INDEX: 111; LEFT: 129px; POSITION: absolute; TOP: 177px" runat="server" Width="392px" Height="142px" TextMode="MultiLine"></asp:TextBox>
			<asp:Label id="Label6" style="Z-INDEX: 110; LEFT: 63px; POSITION: absolute; TOP: 179px" runat="server">Body:</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 109; LEFT: 62px; POSITION: absolute; TOP: 146px" runat="server">Bo</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 108; LEFT: 61px; POSITION: absolute; TOP: 110px" runat="server">From:</asp:Label>
			<asp:TextBox id="TextBox3" style="Z-INDEX: 106; LEFT: 132px; POSITION: absolute; TOP: 145px" runat="server"></asp:TextBox>
			<asp:TextBox id="TextBox2" style="Z-INDEX: 105; LEFT: 131px; POSITION: absolute; TOP: 110px" runat="server"></asp:TextBox>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 58px; POSITION: absolute; TOP: 75px" runat="server">To:</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 23px; POSITION: absolute; TOP: 21px" runat="server" Font-Names="Arial" Font-Bold="True" Font-Size="Medium">Compose Message</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 58px; POSITION: absolute; TOP: 75px" runat="server">To:</asp:Label>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 104; LEFT: 131px; POSITION: absolute; TOP: 75px" runat="server"></asp:TextBox>
		</form>
	</body>
</HTML>
