Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents ltlAlert As System.Web.UI.WebControls.Literal

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

    Private Sub Say(ByVal Message As String)
        ' Format string properly
        Message = Message.Replace("'", "\'")
        Message = Message.Replace(Convert.ToChar(10), "\n")
        Message = Message.Replace(Convert.ToChar(13), "")
        ' Display as JavaScript alert
        ltlAlert.Text = "alert('" & Message & "')"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Say("Sorry, your password is invalid! " & _
            Microsoft.VisualBasic.vbNewLine & _
            "Please try again, or click the Signup button to register now.")
    End Sub
End Class
