<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sample.aspx.vb" Inherits="Ch3___Authentication.sample"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>sample</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 37px; POSITION: absolute; TOP: 29px" runat="server">This is a sample Web page. You cannot access it until you are authenticated.</asp:Label>
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 200px; POSITION: absolute; TOP: 314px" runat="server" Text="Click here to explicity sign out" Width="212px"></asp:Button>
		</form>
	</body>
</HTML>
