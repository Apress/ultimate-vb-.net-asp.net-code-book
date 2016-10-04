<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="Ch3___Uploading_Files.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>The Secrets to Uploading Files with Ease</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" encType="multipart/form-data" runat="server">
			<INPUT id="fileUpload" style="Z-INDEX: 101; LEFT: 93px; POSITION: absolute; TOP: 103px" type="file" name="File1" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 156px" runat="server" Text="Upload File"></asp:button><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 22px; POSITION: absolute; TOP: 21px" runat="server" Font-Size="Medium" Font-Bold="True" Font-Names="Arial">File Upload Demonstration</asp:label><asp:label id="Label2" style="Z-INDEX: 104; LEFT: 26px; POSITION: absolute; TOP: 54px" runat="server">Select an Access database to upload to the server.</asp:label>
			<asp:Label id="lblError" style="Z-INDEX: 105; LEFT: 36px; POSITION: absolute; TOP: 161px" runat="server"></asp:Label></form>
	</body>
</HTML>
