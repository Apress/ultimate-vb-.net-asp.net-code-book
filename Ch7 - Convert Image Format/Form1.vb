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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(352, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 150)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Convert image format"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ConvertImage(Application.StartupPath & "\sample.gif", _
            System.Drawing.Imaging.ImageFormat.Bmp, "c:\newimage.bmp")
    End Sub

    Public Sub ConvertImage(ByVal Filename As String, _
        ByVal DesiredFormat As System.Drawing.Imaging.ImageFormat, _
        ByVal NewFilename As String)
        ' Takes a filename and saves the file in a new format
        Try
            Dim imgFile As System.Drawing.Image = _
                System.Drawing.Image.FromFile(Filename)
            imgFile.Save(NewFilename, DesiredFormat)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
