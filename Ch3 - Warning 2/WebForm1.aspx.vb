Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public Sub DisplayMessage(ByVal MessageTitle As String, _
        ByVal MessageDetails As String, _
        Optional ByVal PageTitle As String = "Attention!", _
        Optional ByVal DelayInSeconds As Integer = 2)
        ' Core HTML, with refresh
        Dim strResponse As String = "<html><head><title>" & _
               "%page-title%</title><META HTTP-EQUIV=""Refresh"" " & _
            "CONTENT=""%delay%; url=javascript:history.back();"">" & _
            "</head><body><div align=""center""><center>" & _
            "<table border=""0"" cellpadding=""0"" cellspacing=""0"" " & _
            "width=""100%"" height=""100%""><tr><td width=""100%"">" & _
            "<p align=""center""><b><font face=""Arial"" size=""6"">" & _
            "%message-title%</font></b></p><p align=""center"">" & _
            "<font face=""Arial"" size=""3""><b>%message-details%</b>" & _
            "</font></td></tr></table></center></div></body></html>"
        ' Replace defaults
        strResponse = strResponse.Replace("%page-title%", PageTitle)
        strResponse = strResponse.Replace("%message-title%", MessageTitle)
        strResponse = strResponse.Replace("%message-details%", _
            MessageDetails)
        strResponse = strResponse.Replace("%delay%", _
            DelayInSeconds.ToString)
        ' Display response
        Response.Clear()
        Response.Write(strResponse)
        Response.End()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DisplayMessage("Sorry!", "That username already exists. Please choose another.", "White Cliff - Error", 2)
    End Sub
End Class
