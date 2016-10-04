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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Bind to Enum"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(104, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(184, 82)
        Me.ListBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Display Value of Selected"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 246)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.ListBox1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum Test
        ABC = 1
        DEF = 2
        GHI = 3
    End Enum

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.DataSource = System.Enum.GetNames(GetType(Test))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strNames As Array = _
            System.Enum.GetValues(GetType(Test))
        Dim strValue As String = _
            strNames(ListBox1.SelectedIndex)
        MessageBox.Show(strValue)
    End Sub
End Class
