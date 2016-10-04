Public Class WebForm1
    Inherits System.Web.UI.Page

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

        ' EXAMPLE: try visiting
        ' http://localhost/Ch3%20-%20Thumbnails/WebForm1.aspx?filename=whitecliff.bmp&width=400

        ' Initialise objects
        Dim objImage, objThumbnail As System.Drawing.Image
        Dim strServerPath, strFilename As String
        Dim shtWidth, shtHeight As Short
        ' Get core path on server - use an empty string if root
        strServerPath = Server.MapPath("images\")
        ' Retrieve name of file to resize from query string
        strFilename = strServerPath & Request.QueryString("filename")
        ' Retrieve file, or error.gif if not available
        Try
            objImage = objImage.FromFile(strFilename)
        Catch
            objImage = objImage.FromFile(strServerPath & "error.gif")
        End Try
        ' Retrieve width from query string
        If Request.QueryString("width") = Nothing Then
            shtWidth = objImage.Width
        ElseIf Request.QueryString("width") < 1 Then
            shtWidth = 100
        Else
            shtWidth = Request.QueryString("width")
        End If
        ' Work out a proportionate height from width
        shtHeight = objImage.Height / (objImage.Width / shtWidth)
        ' Create thumbnail
        objThumbnail = objImage.GetThumbnailImage(shtWidth, _
          shtHeight, Nothing, System.IntPtr.Zero)
        ' Send down to client
        Response.ContentType = "image/jpeg"
        objThumbnail.Save(Response.OutputStream, Imaging.ImageFormat.Jpeg)
        ' Tidy up
        objImage.Dispose()
        objThumbnail.Dispose()
    End Sub

End Class
