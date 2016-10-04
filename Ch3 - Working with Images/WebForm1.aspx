<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch3___Working_with_Images.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Working with Uploaded Images</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" encType="multipart/form-data" runat="server">
			<INPUT id="MyFileField" style="Z-INDEX: 101; LEFT: 33px; POSITION: absolute; TOP: 24px" type="file" runat="server">
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 60px" runat="server" Text="Get information about this image" Width="242px" Height="26px"></asp:Button>
		</form>
	</body>
</HTML>
