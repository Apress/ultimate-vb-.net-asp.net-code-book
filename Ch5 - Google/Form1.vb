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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblSuggestion As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblSuggestion = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Karl Moore"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sample Search"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter a term:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Go"
        '
        'lstResults
        '
        Me.lstResults.Location = New System.Drawing.Point(56, 88)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(392, 95)
        Me.lstResults.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(352, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 24)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Go"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter a term:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Word Suggestion"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 232)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Britnee Speyers"
        '
        'lblSuggestion
        '
        Me.lblSuggestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggestion.Location = New System.Drawing.Point(152, 264)
        Me.lblSuggestion.Name = "lblSuggestion"
        Me.lblSuggestion.Size = New System.Drawing.Size(248, 16)
        Me.lblSuggestion.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 24)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Go"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(56, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Enter a URL:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Retrieve Cached Page"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(152, 328)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 20)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = "www.karlmoore.com"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button3, Me.Label6, Me.Label7, Me.TextBox3, Me.lblSuggestion, Me.Button2, Me.Label3, Me.Label4, Me.TextBox2, Me.lstResults, Me.Button1, Me.Label2, Me.Label1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Adding Google Search to your Programs"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a new Google search object
        Dim objSearch As New _
            com.google.api.GoogleSearchService()
        ' Invoke the search method
        Dim objResults As _
            com.google.api.GoogleSearchResult = _
         objSearch.doGoogleSearch( _
        "xxxxxxxxxxx", _
        TextBox1.Text, 0, 10, False, "", False, _
        "", "", "")
        ' Loop through result elements
        Dim shtCount As Short
        For shtCount = 0 To objResults.endIndex - 1
            lstResults.Items.Add(StripTags(objResults.resultElements(shtCount).title) & _
                " - " & objResults.resultElements(shtCount).URL)
        Next
    End Sub
    Public Function StripTags(ByVal HTML As String) As String
        ' Removes tags from passed HTML
        Dim objRegEx As _
            System.Text.RegularExpressions.Regex
        Return objRegEx.Replace(HTML, "<[^>]*>", "")
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Create a new Google search object
        Dim objSearch As New _
            com.google.api.GoogleSearchService()
        ' Retrieve the suggest spelling, if any
        Dim strSuggestion As String
        strSuggestion = objSearch.doSpellingSuggestion( _
            "xxxxxxxxxxx", _
            TextBox2.Text)
        If strSuggestion <> "" Then
            lblSuggestion.Text = "Did you mean " & strSuggestion & "?"
        Else
            lblSuggestion.Text = "Looks okay to me!"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Create a new Google search object
        Dim objSearch As New _
            com.google.api.GoogleSearchService()
        ' Retrieve cached version of a page
        Dim bytPage() As Byte = _
         objSearch.doGetCachedPage( _
            "xxxxxxxxxxx", _
            TextBox3.Text)
        ' Convert base 64 byte array to string
        Dim strHTML As String = _
            System.Text.ASCIIEncoding.ASCII.GetString(bytPage)
        ' Process HTML
        If strHTML.IndexOf("did not match any documents.") = -1 Then
            Clipboard.SetDataObject(strHTML)
            MessageBox.Show("Cached HTML sent to clipboard")
        Else
            MessageBox.Show("Can't find cached version of " & TextBox3.Text)
        End If
    End Sub
End Class
