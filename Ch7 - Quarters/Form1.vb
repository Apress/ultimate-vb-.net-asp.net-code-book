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
    Friend WithEvents cal1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents cal2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cal1 = New System.Windows.Forms.MonthCalendar()
        Me.cal2 = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cal1
        '
        Me.cal1.Location = New System.Drawing.Point(40, 96)
        Me.cal1.Name = "cal1"
        Me.cal1.TabIndex = 0
        '
        'cal2
        '
        Me.cal2.Location = New System.Drawing.Point(304, 96)
        Me.cal2.Name = "cal2"
        Me.cal2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(40, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(464, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Click here to view current quarter start/end dates"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current quarter start:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Current quarter end:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 286)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.Button1, Me.cal2, Me.cal1})
        Me.Name = "Form1"
        Me.Text = "Figuring out Quarters"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CurrentQuarterStart As Date = FirstDayOfQuarter(Now)
        Dim CurrentQuarterEnd As Date = LastDayOfQuarter(Now)
        cal1.SetDate(CurrentQuarterStart)
        cal2.SetDate(CurrentQuarterEnd)
    End Sub

    Public Function FirstDayOfQuarter(ByVal DateIn As Date) As Date
        ' Calculate first day of DateIn quarter,
        ' with quarters starting at the beginning of Jan/Apr/Jul/Oct
        Dim intQuarterNum As Integer = (Month(DateIn) - 1) \ 3 + 1
        Return DateSerial(Year(DateIn), 3 * intQuarterNum - 2, 1)
    End Function

    Public Function LastDayOfQuarter(ByVal DateIn As Date) As Date
        ' Calculate last day of DateIn quarter,
        ' with quarters ending at the end of Mar/Jun/Sep/Dec
        Dim intQuarterNum As Integer = (Month(DateIn) - 1) \ 3 + 1
        Return DateSerial(Year(DateIn), 3 * intQuarterNum + 1, 0)
    End Function

End Class
