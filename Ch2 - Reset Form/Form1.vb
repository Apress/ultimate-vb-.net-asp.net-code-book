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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "TextBox1"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(64, 64)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "CheckBox1"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Item #1", "Item #2", "Item #3"})
        Me.ComboBox1.Location = New System.Drawing.Point(64, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Reset This Form"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1})
        Me.TabControl1.Location = New System.Drawing.Point(240, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(120, 88)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.CheckBox2})
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(112, 62)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(16, 24)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "CheckBox2"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 181)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1, Me.Button1, Me.ComboBox1, Me.CheckBox1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ResetForm(Me)
    End Sub

    Public Sub ResetForm(ByVal FormToReset As Form)
        ' Resets the main data entry controls on the passed FormToReset
        Dim objControl As Control
        ' Loop around every control on the form and run the reset method
        For Each objControl In FormToReset.Controls
            ResetControl(objControl)
        Next
    End Sub

    Public Sub ResetControl(ByVal ControlToReset As Control)
        ' Resets the core control, then loops and
        ' resets any sub controls, such as Tab pages
        Dim intCount As Integer
        ClearControl(ControlToReset)
        If ControlToReset.Controls.Count > 0 Then
            For intCount = 1 To ControlToReset.Controls.Count
                ResetControl(ControlToReset.Controls(intCount - 1))
            Next
        End If
    End Sub

    Public Sub ClearControl(ByVal ControlToClear As Control)
        ' Clears the value of a particular control -
        ' you may wish to extend this to suit your exact needs
        If InStr(ControlToClear.Tag, "skip", CompareMethod.Text) = 0 Then
            If TypeOf (ControlToClear) Is System.Windows.Forms.TextBox Then
                ControlToClear.Text = ""  ' Clear TextBox
            ElseIf TypeOf (ControlToClear) Is System.Windows.Forms.CheckBox Then
                Dim objCheckBox As System.Windows.Forms.CheckBox = ControlToClear
                objCheckBox.Checked = False ' Uncheck CheckBox
            ElseIf TypeOf (ControlToClear) Is System.Windows.Forms.ComboBox Then
                Dim objComboBox As System.Windows.Forms.ComboBox = ControlToClear
                objComboBox.SelectedIndex = -1 ' Deselect any ComboBox entry
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Select sample item in combo box
        ComboBox1.SelectedIndex = 1
    End Sub
End Class
