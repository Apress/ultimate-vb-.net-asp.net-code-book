Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents MyFileField As System.Web.UI.HtmlControls.HtmlInputFile
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Get data into image format
        Dim objStream As System.IO.Stream = _
          MyFileField.PostedFile.InputStream
        Dim objImage As System.Drawing.Image
        Try
            ' Get the image stream
            objImage = System.Drawing.Image.FromStream(objStream)
        Catch
            ' This is not an image, exit the method (presuming code is in one!)
            Exit Sub
        End Try
        ' Filename
        Dim strOriginalFilename As String = MyFileField.PostedFile.FileName
        ' Type of image
        Dim strImageType
        If objImage.RawFormat.Equals(objImage.RawFormat.Gif) Then
            strImageType = "This is a GIF image"
        ElseIf objImage.RawFormat.Equals(objImage.RawFormat.Bmp) Then
            strImageType = "This is a Bitmap image"
        ElseIf objImage.RawFormat.Equals(objImage.RawFormat.Jpeg) Then
            strImageType = "This is a JPEG image"
        ElseIf objImage.RawFormat.Equals(objImage.RawFormat.Icon) Then
            strImageType = "This is an icon file"
        ElseIf objImage.RawFormat.Equals(objImage.RawFormat.Tiff) Then
            strImageType = "This is a TIFF file"
        Else
            strImageType = "Other"
        End If
        ' Dimensions
        Dim strDimensions As String
        strDimensions = "Width in pixels: " & objImage.Width & _
          ", Height in pixels: " & objImage.Height
        ' Send raw output to browser
        Response.Clear()
        Response.Write(strOriginalFilename & "<p>" & strImageType & _
          "<p>" & strDimensions)
        Response.End()

    End Sub
End Class
