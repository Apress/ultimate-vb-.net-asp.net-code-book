Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strReport As String
        Dim objInfo As ProcessInfo = ProcessModelInfo.GetCurrentProcessInfo
        ' Get time information
        strReport = "ASP.NET was started at " & _
            objInfo.StartTime.ToString & ". " & _
            "It has been running for " & _
            objInfo.Age.Days & " days, " & _
            objInfo.Age.Hours & " hours and " & _
            objInfo.Age.Minutes & " minutes. "
        Response.Write(strReport)
        ' Get other info
        strReport = "The process ID is " & _
            objInfo.ProcessID & ". " & _
            "Current status is " & _
            objInfo.Status.ToString & ". " & _
            "Peak memory used was " & _
            objInfo.PeakMemoryUsed & ". " & _
            "Request count is currently " & _
            objInfo.RequestCount & "."
        Response.Write(strReport)
    End Sub

End Class
