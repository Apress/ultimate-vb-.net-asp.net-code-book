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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TB As System.Windows.Forms.TextBox
    Friend WithEvents RTB As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RTB = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RTB
        '
        Me.RTB.Location = New System.Drawing.Point(16, 32)
        Me.RTB.Name = "RTB"
        Me.RTB.Size = New System.Drawing.Size(432, 104)
        Me.RTB.TabIndex = 0
        Me.RTB.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paste a little formatted text from Word or WordPad here:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 152)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(376, 23)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here to extract HTML from the above RichTextBox control:"
        '
        'TB
        '
        Me.TB.Location = New System.Drawing.Point(16, 176)
        Me.TB.Multiline = True
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(432, 128)
        Me.TB.TabIndex = 3
        Me.TB.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 318)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TB, Me.LinkLabel1, Me.Label1, Me.RTB})
        Me.Name = "Form1"
        Me.Text = "Converting RTF to HTML"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TB.Text = ConvertToHTML(RTB)
    End Sub
    Public Function ConvertToHTML(ByVal Box As RichTextBox) As String
        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer
        ' If nothing in the box, exit
        If Box.Text.Length = 0 Then Exit Function
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Box.TextLength
        Box.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Setup initial parameters
        strColour = Box.SelectionColor.ToKnownColor.ToString
        blnBold = Box.SelectionFont.Bold
        blnItalic = Box.SelectionFont.Italic
        strFont = Box.SelectionFont.FontFamily.Name
        shtSize = Box.SelectionFont.Size
        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont & _
          "; font-size: " & shtSize & "pt; color: " & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If
        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character
        strHTML += Box.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Box.Text.Length
            ' Select current character
            Box.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Box.Text.Substring(intCount - 1, 1) = Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Box.SelectionColor.ToKnownColor.ToString <> strColour _
                Or Box.SelectionFont.FontFamily.Name <> strFont Or _
                Box.SelectionFont.Size <> shtSize Then
                strHTML += "</span><span style=""font-family: " _
                  & Box.SelectionFont.FontFamily.Name & _
                  "; font-size: " & Box.SelectionFont.Size & _
                  "pt; color: " & _
                  Box.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Box.SelectionFont.Bold <> blnBold Then
                If Box.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for italic changes
            If Box.SelectionFont.Italic <> blnItalic Then
                If Box.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Box.Text, intCount, 1)
            ' Update variables with current style
            strColour = Box.SelectionColor.ToKnownColor.ToString
            blnBold = Box.SelectionFont.Bold
            blnItalic = Box.SelectionFont.Italic
            strFont = Box.SelectionFont.FontFamily.Name
            shtSize = Box.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += "</b>"
        If blnItalic = True Then strHTML += "</i>"
        ' Terminate outstanding HTML tags
        strHTML += "</span></html>"
        ' Restore original RichTextBox selection
        Box.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
    End Function

End Class
