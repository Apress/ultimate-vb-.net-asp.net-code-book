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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(312, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2})
        Me.TabControl1.Location = New System.Drawing.Point(24, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(216, 112)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(208, 86)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(208, 86)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 208)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(216, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Value = 29
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(432, 32)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.TabIndex = 3
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(328, 104)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.TabIndex = 4
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(24, 152)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(208, 45)
        Me.TrackBar1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(312, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "TextBox1"
        '
        'CheckBox1
        '
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox1.Location = New System.Drawing.Point(312, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "CheckBox1"
        '
        'RadioButton1
        '
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton1.Location = New System.Drawing.Point(312, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "RadioButton1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "To test this application, do not recompile!"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Go to the Bin folder and run the modified ""Ch2 - Win XP Themes.exe"""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 286)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.RadioButton1, Me.CheckBox1, Me.TextBox1, Me.TrackBar1, Me.HScrollBar1, Me.VScrollBar1, Me.ProgressBar1, Me.TabControl1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Example Windows XP Theming"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
