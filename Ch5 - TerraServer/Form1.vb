Imports Ch5___TerraServer.net.terraservice

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Go"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter a site:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Place Search"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(40, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Statue of Liberty", "Pentagon", "White House", "Hoover Dam"})
        Me.ComboBox1.Location = New System.Drawing.Point(176, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 334)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox1, Me.PictureBox1, Me.Button1, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "View the Real World in your Application, with TerraServer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub CreateBitmapFromPlaceName( _
        ByVal PlaceName As String, ByVal Filename As String)
        ' Size of image to create
        Const WIDTH As Integer = 600
        Const HEIGHT As Integer = 400
        ' Setup objects to use
        Dim objTheme As New Theme()
        Dim objScale As New Scale()
        Dim objTS As New TerraService()
        Dim objABB As AreaBoundingBox
        Dim imgImage As Image
        Dim objPF() As PlaceFacts
        Try
            ' Retrieve list of matching points
            objPF = objTS.GetPlaceList(PlaceName, 1, False)
            ' If no matches, exit
            If objPF.Length = 0 Then Exit Sub
            ' Settings - type of image and scale
            objTheme = Theme.Photo
            objScale = objScale.Scale2m
            ' Gets details of the final full image AreaBoundingBox
            objABB = objTS.GetAreaFromPt(objPF(0).Center, _
                objTheme, objScale, WIDTH, HEIGHT)
            ' Create objects to handle image in memory
            Dim objPFmt As System.Drawing.Imaging.PixelFormat = _
                System.Drawing.Imaging.PixelFormat.Format32bppRgb
            Dim imgTemp As Image = New Bitmap(WIDTH, HEIGHT, objPFmt)
            Dim objGraphics As Graphics = Graphics.FromImage(imgTemp)
            ' Create objects to store current locations
            Dim intStartX As Integer = objABB.NorthWest.TileMeta.Id.X
            Dim intStartY As Integer = objABB.NorthWest.TileMeta.Id.Y
            Dim x, y As Integer
            ' Cycle through the portions of our whole AreaBoundingBox, 
            ' incrementally retrieving and stiching together our image
            For x = intStartX To objABB.NorthEast.TileMeta.Id.X
                For y = intStartY To objABB.SouthWest.TileMeta.Id.Y Step -1
                    Dim objTID As TileId
                    Dim imgTile As Image
                    objTID = objABB.NorthWest.TileMeta.Id
                    objTID.X = x
                    objTID.Y = y
                    imgTile = Image.FromStream(New System.IO.MemoryStream( _
                        objTS.GetTile(objTID)))
                    objGraphics.DrawImage(imgTile, _
                        (x - intStartX) * imgTile.Width - _
                        objABB.NorthWest.Offset.XOffset, _
                        (intStartY - y) * imgTile.Height - _
                        objABB.NorthWest.Offset.YOffset, _
                        imgTile.Width, imgTile.Height)
                Next
            Next
            ' Finally, save to the passed filename
            imgTemp.Save(Filename, System.Drawing.Imaging.ImageFormat.Bmp)
        Catch
            Return
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CreateBitmapFromPlaceName(ComboBox1.Text, "c:\" & ComboBox1.Text & ".bmp")
        PictureBox1.Image = New Bitmap("c:\" & ComboBox1.Text & ".bmp")

    End Sub
End Class
