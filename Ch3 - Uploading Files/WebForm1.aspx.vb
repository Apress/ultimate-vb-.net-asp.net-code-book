Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents fileUpload As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents lblError As System.Web.UI.WebControls.Label
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
        If FileFieldSelected(fileUpload) Then
            fileUpload.PostedFile.SaveAs(Server.MapPath("uploaded.mdb"))
            lblError.Text = "<br>File uploaded!<br>"
        Else
            lblError.Text = "<br>No file selected.<br>"
        End If
    End Sub

    Public Function FileFieldSelected(ByVal FileField As _
        System.Web.UI.HtmlControls.HtmlInputFile) As Boolean
        ' Returns a True if the passed
        ' FileField has had a user post a file
        Dim intFileLength As Integer
        If FileField.PostedFile Is Nothing Then Return False
        If FileField.PostedFile.ContentLength = 0 Then Return False
        Return True
    End Function

End Class
