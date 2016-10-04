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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(448, 144)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "HTML:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Go"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "http://www.bbc.co.uk/"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter a URL:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 238)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1, Me.Label2, Me.Button1, Me.TextBox2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "How To Snatch HTML, with a Timeout"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = GetPageHTML(TextBox2.Text, InputBox("Enter the server timeout in seconds:"))
    End Sub

    Public Function GetPageHTML(ByVal URL As String, _
           Optional ByVal TimeoutSeconds As Integer = 10) _
           As String
        ' Retrieves the HTML from the specified URL,
        ' using a default timeout of 10 seconds
        Dim objRequest As Net.WebRequest
        Dim objResponse As Net.WebResponse
        Dim objStreamReceive As System.IO.Stream
        Dim objEncoding As System.Text.Encoding
        Dim objStreamRead As System.IO.StreamReader

        Try
            ' Setup our Web request
            objRequest = Net.WebRequest.Create(URL)
            objRequest.Timeout = TimeoutSeconds * 1000
            ' Retrieve data from request
            objResponse = objRequest.GetResponse
            objStreamReceive = objResponse.GetResponseStream
            objEncoding = System.Text.Encoding.GetEncoding( _
                "utf-8")
            objStreamRead = New System.IO.StreamReader( _
                objStreamReceive, objEncoding)
            ' Set function return value
            GetPageHTML = objStreamRead.ReadToEnd()
            ' Check if available, then close response
            If Not objResponse Is Nothing Then
                objResponse.Close()
            End If
        Catch
            ' Error occured grabbing data, simply return nothing
            Return ""
        End Try
    End Function

End Class
