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
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert ""your"" HTML codes to real HTML"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(392, 104)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "[i]Thanks [b]very[/b] much for visiting me[/i] at [url=http://www.karlmoore.com/]" & _
        "Karl Moore.com[/url]."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 200)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(392, 104)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 326)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox2, Me.TextBox1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Define Your Own HTML"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strResult As String
        Dim YourData As String = TextBox1.Text

        ' [url]http://www.karlmoore.com/ /[/url]
        strResult = System.Text.RegularExpressions.Regex.Replace(YourData, _
          "\[url[^>]*?=\s*?[""']?([^'"" >]+?)[ '""]?\]([^\""]*?)\[/url\]", _
          "<a target=""_blank"" href=""$1"">$2</a>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [url=http://www.karlmoore.com/]Karl Moore.com[/url]
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[URL\]([^\""]*?)\[/URL\]", _
          "<a target=""_blank"" href=""$1"" target=""_new"">$1</a>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [email=myname@domain.com]Click here to email me[/email]
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
           "\[email[^>]*?=\s*?[""']?([^'"" >]+?)[ '""]?\]([^\""]*?)\[/email\]", _
           "<a href=""mailto:$1"">$2</a>", _
           System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [email]myname@domain.com[/email]
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[email\]([^\""]*?)\[/email\]", _
          "<a href=""mailto:$1"">$1</a>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [b]some text[/b] produces bold text
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[b\]([^\""]*?)\[/b\]", "<b>$1</b>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [u]some text[/u] produces underlined text 
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[u\]([^\""]*?)\[/u\]", "<u>$1</u>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [i]some text[/i] produces italicised text 
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[i\]([^\""]*?)\[/i\]", "<i>$1</i>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [color=blue]some text[/color] produces blue text
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[color[^>]*?=\s*[""']?([^'"" >]+?)[ '""]?\]([^\""]*)\[/color\]", _
          "<font color=""$1"">$2</font>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [size=4]some text[/size] produces size 4 text
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[size[^>]*?=\s*[""']?([^'"" >]+?)[ '""]?\]([^\""]*)\[/size\]", _
          "<font size=""$1"">$2</font>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [font=courier]some text[/font] produces courier font text
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[font[^>]*?=\s*[""']?([^'"" >]+?)[ '""]?\]([^\""]*)\[/font\]", _
          "<font face=""$1"">$2</font>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [img]http://www.vbforums.com/images/vBulletin_logo.gif[/img]
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[img\]([^\""]*?)\[/img\]", "<img src=""$1"">", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        ' [quote]No. Try not.
        ' Do or do not, there is no try.[/quote]
        strResult = System.Text.RegularExpressions.Regex.Replace(strResult, _
          "\[quote\]([^\""]*?)\[/quote\]", _
          "<blockquote><p><hr>$1<hr></p></blockquote>", _
          System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        TextBox2.Text = strResult

    End Sub
End Class
