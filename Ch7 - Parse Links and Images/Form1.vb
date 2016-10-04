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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 56)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(440, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Click here to retrieve sample HTML from newslinx.com"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Grab links from HTML"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(24, 152)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 108)
        Me.ListBox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.Location = New System.Drawing.Point(264, 152)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(200, 108)
        Me.ListBox2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Grab images from HTML"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 278)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListBox2, Me.Button3, Me.ListBox1, Me.Button2, Me.Button1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Tricks of Parsing a Web Page for Links and Images"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetPageHTML(ByVal URL As String) As String
        ' Retrieves the HTML from the specified URL
        Dim objWC As New System.Net.WebClient()
        Return New System.Text.UTF8Encoding().GetString( _
            objWC.DownloadData(URL))
    End Function

    Public Function ParseLinks(ByVal HTML As String) As ArrayList
        ' Remember to add the following at top of class:
        ' - Imports System.Text.RegularExpressions
        Dim objRegEx As System.Text.RegularExpressions.Regex
        Dim objMatch As System.Text.RegularExpressions.Match
        Dim arrLinks As New System.Collections.ArrayList()
        ' Create regular expression
        objRegEx = New System.Text.RegularExpressions.Regex( _
            "a.*href\s*=\s*(?:""(?<1>[^""]*)""|(?<1>\S+))", _
            System.Text.RegularExpressions.RegexOptions.IgnoreCase Or _
            System.Text.RegularExpressions.RegexOptions.Compiled)
        ' Match expression to HTML
        objMatch = objRegEx.Match(HTML)
        ' Loop through matches and add <1> to ArrayList
        While objMatch.Success
            Dim strMatch As String
            strMatch = objMatch.Groups(1).ToString
            arrLinks.Add(strMatch)
            objMatch = objMatch.NextMatch()
        End While
        ' Pass back results
        Return arrLinks
    End Function

    Public Function ParseImages(ByVal HTML As String) As ArrayList
        ' Remember to add the following at top of class:
        ' - Imports System.Text.RegularExpressions
        Dim objRegEx As System.Text.RegularExpressions.Regex
        Dim objMatch As System.Text.RegularExpressions.Match
        Dim arrLinks As New System.Collections.ArrayList()
        ' Create regular expression
        objRegEx = New System.Text.RegularExpressions.Regex( _
            "img.*src\s*=\s*(?:""(?<1>[^""]*)""|(?<1>\S+))", _
            System.Text.RegularExpressions.RegexOptions.IgnoreCase Or _
            System.Text.RegularExpressions.RegexOptions.Compiled)
        ' Match expression to HTML
        objMatch = objRegEx.Match(HTML)
        ' Loop through matches and add <1> to ArrayList
        While objMatch.Success
            Dim strMatch As String
            strMatch = objMatch.Groups(1).ToString
            arrLinks.Add(strMatch)
            objMatch = objMatch.NextMatch()
        End While
        ' Pass back results
        Return arrLinks
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = GetPageHTML("http://www.newslinx.com/")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim arrLinks As ArrayList = ParseLinks(TextBox1.Text)
        ' Loop through results
        Dim shtCount As Integer
        For shtCount = 0 To arrLinks.Count - 1
            ListBox1.Items.Add(arrLinks(shtCount).ToString)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim arrLinks As ArrayList = ParseImages(TextBox1.Text)
        ' Loop through results
        Dim shtCount As Integer
        For shtCount = 0 To arrLinks.Count - 1
            ListBox2.Items.Add(arrLinks(shtCount).ToString)
        Next
    End Sub

End Class
