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
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(80, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 96)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Write sample text and return filename!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 238)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Writing to a Temporary File"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strFilename = WriteToTempFile("This is my data for the temporary file.")
        MessageBox.Show(strFilename)
    End Sub

    Public Function WriteToTempFile(ByVal Data As String) As String
        ' Writes text to a temporary file and returns path
        Dim strFilename As String = System.IO.Path.GetTempFileName()
        Dim objFS As New System.IO.FileStream(strFilename, System.IO.FileMode.Append, System.IO.FileAccess.Write)
        ' Opens stream and begins writing
        Dim Writer As New System.IO.StreamWriter(objFS)
        Writer.BaseStream.Seek(0, System.IO.SeekOrigin.End)
        Writer.WriteLine(Data)
        Writer.Flush()
        ' Closes and returns temp path
        Writer.Close()
        Return strFilename
    End Function


End Class
