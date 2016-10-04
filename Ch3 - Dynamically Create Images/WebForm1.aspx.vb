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
        ' Create image - you could even load an image
        ' from a file and edit it in code
        Dim objBitmap As Bitmap = New Bitmap(120, 30)
        Dim objGraphics As Graphics = Graphics.FromImage(objBitmap)
        ' Fill background
        objGraphics.FillRectangle(New SolidBrush(Color.LightBlue), _
          0, 0, 120, 30)
        ' Create blue-yellow bullet point
        objGraphics.FillEllipse(New SolidBrush(Color.Blue), 3, 9, 10, 10)
        objGraphics.FillEllipse(New SolidBrush(Color.Yellow), 4, 10, 8, 8)
        ' Draw text next to bullet point
        objGraphics.DrawString("Empty Karl's Basket", _
            New Font("Tahoma", 8), New SolidBrush(Color.Green), 16, 8)
        ' Send down to client
        Response.Clear()
        Response.ContentType = "image/jpeg"
        objBitmap.Save(Response.OutputStream, _
          System.Drawing.Imaging.ImageFormat.Jpeg)
        ' Tidy up
        objGraphics.Dispose()
        objBitmap.Dispose()
    End Sub

End Class
