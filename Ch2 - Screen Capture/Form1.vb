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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(288, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Click to Capture the Screen"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 166)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.PictureBox1})
        Me.Name = "Form1"
        Me.Text = "Capturing the Screen, Quick and Easy"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GetScreenCapture(True).Save("c:\screengrab.bmp")
        PictureBox1.Image = GetScreenCapture()
    End Sub

    Public Function GetScreenCapture( _
        Optional ByVal FullScreen As Boolean = False) As Image
        ' Captures the current screen and returns as an Image object
        Dim objSK As SendKeys
        Dim imgCapture As Image
        If FullScreen = True Then
            ' Print Screen pressed twice here as some systems
            ' grab active window "accidentally" on first run
            objSK.SendWait("{PRTSC 2}")
        Else
            objSK.SendWait("%{PRTSC}")
        End If
        Dim objData As IDataObject = Clipboard.GetDataObject()
        Return objData.GetData(DataFormats.Bitmap)
    End Function

End Class
