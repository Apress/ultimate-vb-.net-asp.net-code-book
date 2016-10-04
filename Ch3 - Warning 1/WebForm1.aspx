<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch3___Warning_1.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Displaying Web Warning Messages: Technique 1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="Button1" style="Z-INDEX: 101; LEFT: 27px; POSITION: absolute; TOP: 23px" runat="server" Text="Click to Demonstrate"></asp:Button>
		</form>
		<script>
	<asp:Literal id="ltlAlert" runat="server" EnableViewState="False"> 
	  </asp:Literal>
		</script>
	</body>
</HTML>
