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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"(all)", "Angela Lansbury", "Peter Ustinov", "Elvis Presley", "Suzanne Vega"})
        Me.ComboBox1.Location = New System.Drawing.Point(88, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Try typing a few characters and seeing this AutoComplete combo box in action:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label1, Me.ComboBox1})
        Me.Name = "Form1"
        Me.Text = "Save User Time: Add AutoComplete to Combo Boxes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ComboBox1_KeyUp(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyUp
        AutoCompleteKeyUp(ComboBox1, e)
    End Sub
    Private Sub ComboBox1_Leave(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles ComboBox1.Leave
        AutoCompleteLeave(ComboBox1)
    End Sub

    Public Sub AutoCompleteKeyUp(ByVal Combo As ComboBox, _
        ByVal e As KeyEventArgs)
        Dim strTyped As String
        Dim intFoundIndex As Integer
        Dim objFoundItem As Object
        Dim strFoundText As String
        Dim strAppendText As String
        ' Ignore basic selection keys
        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, _
                Keys.Delete, Keys.Down, Keys.CapsLock
                Return
        End Select
        ' Find what user has typed in list
        strTyped = Combo.Text
        intFoundIndex = Combo.FindString(strTyped)
        ' If found...
        If intFoundIndex >= 0 Then
            ' Get list item (actual type depends on whether data bound)
            objFoundItem = Combo.Items(intFoundIndex)
            ' Use control to resolve text - in case data bound
            strFoundText = Combo.GetItemText(objFoundItem)
            ' Append the typed text to rest of the found string
            ' (text is set twice due to a combo box quirk:
            '  on certain platforms, setting just once ignores casing!)
            strAppendText = strFoundText.Substring(strTyped.Length)
            Combo.Text = strTyped & strAppendText
            Combo.Text = strTyped & strAppendText
            ' Select the appended text
            Combo.SelectionStart = strTyped.Length
            Combo.SelectionLength = strAppendText.Length
        End If
    End Sub

    Public Sub AutoCompleteLeave(ByVal Combo As ComboBox)
        ' Correct casing when leaving combo
        Dim intFoundIndex As Integer
        intFoundIndex = Combo.FindStringExact(Combo.Text)
        Combo.SelectedIndex = -1
        Combo.SelectedIndex = intFoundIndex
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
