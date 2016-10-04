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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(440, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Click here to retrieve sample HTML from bbc.co.uk"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 56)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(440, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Click here to convert HTML to text"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 152)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(440, 136)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 302)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.TextBox2, Me.Button1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Converting HTML to Text, Easily"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = StripTags(TextBox1.Text)
    End Sub

    Public Function StripTags(ByVal HTML As String) As String
        ' Removes tags from passed HTML
        Dim objRegEx As _
            System.Text.RegularExpressions.Regex
        Return objRegEx.Replace(HTML, "<[^>]*>", "")
    End Function

    Public Function GetPageHTML(ByVal URL As String) As String
        ' Retrieves the HTML from the specified URL
        Dim objWC As New System.Net.WebClient()
        Return New System.Text.UTF8Encoding().GetString( _
            objWC.DownloadData(URL))
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = GetPageHTML("http://www.bbc.co.uk/")
    End Sub
End Class
