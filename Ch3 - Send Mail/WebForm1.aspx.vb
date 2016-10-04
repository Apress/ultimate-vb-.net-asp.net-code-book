Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
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
        'Put user code to initialize the page here
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SendMail(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, False, "karlmoore.com") Then
            Response.Write("Message sent!")
        Else
            Response.Write("Unsuccessful: message not sent. Check the e-mail address and SMTP server argument.")
        End If
    End Sub

    Public Function SendMail(ByVal [To] As String, _
        ByVal From As String, ByVal Subject As String, _
        ByVal Body As String, ByVal IsHTML As Boolean, _
        Optional ByVal SmtpServer As String = "domain.com") As Boolean
        ' Sends a mail message using the specified details
        ' - returns a False if delivery fails
        Try
            Dim objMsg As New System.Web.Mail.MailMessage()
            SendMail = True
            With objMsg
                .To = [To]
                .From = From
                .Subject = Subject
                .Body = Body
                ' .BodyFormat specifies whether the Body is
                ' in plain text or HTML format
                .BodyFormat = IIf(IsHTML = True, _
                    System.Web.Mail.MailFormat.Html, _
                    System.Web.Mail.MailFormat.Text)
            End With
            System.Web.Mail.SmtpMail.SmtpServer = SmtpServer
            System.Web.Mail.SmtpMail.Send(objMsg)
        Catch
            SendMail = False
        End Try
    End Function

End Class
