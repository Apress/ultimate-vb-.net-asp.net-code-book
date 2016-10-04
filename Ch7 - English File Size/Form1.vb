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
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(360, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click here and select any file!"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 24)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 48)
        Me.Label2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 182)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "How Big Is That File – In English?"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function ConvertBytes(ByVal Bytes As Long) As String
        ' Converts bytes into a readable "1.44 MB", etc. string
        If Bytes >= 1073741824 Then
            Return Format(Bytes / 1024 / 1024 / 1024, "#0.00") _
                 & " GB"
        ElseIf Bytes >= 1048576 Then
            Return Format(Bytes / 1024 / 1024, "#0.00") & " MB"
        ElseIf Bytes >= 1024 Then
            Return Format(Bytes / 1024, "#0.00") & " KB"
        ElseIf Bytes > 0 And Bytes < 1024 Then
            Return Fix(Bytes) & " Bytes"
        Else
            Return "0 Bytes"
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OFD.ShowDialog()
        Dim objInfo As New System.IO.FileInfo(OFD.FileName)
        Label1.Text = "The file is " & objInfo.Length & " bytes, which is..."
        Label2.Text = ConvertBytes(objInfo.Length)
    End Sub
End Class
