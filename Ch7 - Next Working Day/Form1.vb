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
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter a value then click here"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(280, 32)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "5"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter number of days to shift by:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ie, 5 or -1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 222)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.TextBox1, Me.MonthCalendar1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Working with working days"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim datNewDate As Date = AddWorkingDays(Today, TextBox1.Text)
        MonthCalendar1.SetDate(datNewDate)
    End Sub

    Public Function AddWorkingDays(ByVal DateIn As Date, ByVal ShiftDate As Integer) As Date
        ' Adds the [ShiftDate] number of working days to DateIn
        Dim datDate As Date = DateIn.AddDays(ShiftDate)
        ' Loop around until we get the need non-weekend day
        While Weekday(datDate) = 1 Or Weekday(datDate) = 7
            datDate = datDate.AddDays(IIf(ShiftDate < 0, -1, 1))
        End While
        Return datDate
    End Function


End Class
