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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(424, 224)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open File"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save File"
        '
        'SFD
        '
        Me.SFD.FileName = "doc1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 326)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Two Easy-to-Use Functions for Reading and Writing Files"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function ReadTextFromFile(ByVal Filename As String) As String
        ' Returns text from the specified file
        On Error Resume Next
        Dim strFileText As String
        ' Open the file and launch StreamReader object
        Dim MyReader As System.IO.StreamReader = _
           System.IO.File.OpenText(Filename)
        ' Read all text through to the end
        strFileText = MyReader.ReadToEnd
        ' Close the stream
        MyReader.Close()
        ' Return data
        Return strFileText
    End Function

    Public Sub WriteTextToFile(ByVal Filename As String, ByVal Text As String)
        ' Writes the passed Text into the specified file
        ' Create file and StreamWriter object
        Dim MyWriter As System.IO.StreamWriter = _
           System.IO.File.CreateText(Filename)
        ' Write text to the stream
        MyWriter.Write(Text)
        ' Close the stream
        MyWriter.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OFD.ShowDialog()
        TextBox1.Text = ReadTextFromFile(OFD.FileName)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SFD.ShowDialog()
        WriteTextToFile(SFD.FileName, TextBox1.Text)
    End Sub
End Class
