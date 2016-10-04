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
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents box1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.box1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'box1
        '
        Me.box1.Location = New System.Drawing.Point(40, 80)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(304, 264)
        Me.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.box1.TabIndex = 0
        Me.box1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(40, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(328, 23)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here to rotate the image!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 382)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabel1, Me.box1})
        Me.Name = "Form1"
        Me.Text = "Rotating an image"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim objImage As Image = box1.Image
        objImage.RotateFlip(RotateFlipType.RotateNoneFlipY)
        box1.Image = objImage
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        box1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\sample.gif")
        box1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class
