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
        Me.Button1.Location = New System.Drawing.Point(96, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click here to compare 1.jpg and 2.jpg"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 214)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Check whether two files are identical..."
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function CompareFiles(ByVal File1 As String, _
        ByVal File2 As String) As Boolean
        ' Compares two files, byte by byte
        ' and returns true if no differences
        Dim blnIdentical As Boolean = True
        Dim objFS1 As System.IO.FileStream = _
            New System.IO.FileStream(File1, System.IO.FileMode.Open)
        Dim objFS2 As System.IO.FileStream = _
            New System.IO.FileStream(File2, System.IO.FileMode.Open)
        ' Begin by checking length
        If (objFS1.Length <> objFS2.Length) Then
            blnIdentical = False
        Else
            ' Start looping through, comparing bytes
            Dim intByteF1 As Integer
            Dim intByteF2 As Integer
            Do
                intByteF1 = objFS1.ReadByte()
                intByteF2 = objFS2.ReadByte()
                If intByteF1 <> intByteF2 Then
                    blnIdentical = False
                    Exit Do
                End If
            Loop While (intByteF1 <> -1)
        End If
        ' Close files and set return value
        objFS1.Close()
        objFS2.Close()
        Return blnIdentical
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CompareFiles(Application.StartupPath & "\1.jpg", Application.StartupPath & "\2.jpg") Then
            MessageBox.Show("Files are identical!")
        Else
            MessageBox.Show("Files do not match!")
        End If
    End Sub
End Class
