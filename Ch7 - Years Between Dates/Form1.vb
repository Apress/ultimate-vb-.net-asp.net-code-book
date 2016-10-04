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
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(32, 96)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(280, 96)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(32, 40)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(456, 23)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Select a start and end date below, then click here to calculate number of years d" & _
        "ifference"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 278)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabel1, Me.MonthCalendar2, Me.MonthCalendar1})
        Me.Name = "Form1"
        Me.Text = "Calculating the years between dates"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("There are " & _
            YearsBetweenDates(MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart) & _
            " years between the two specified dates.")
    End Sub

    Public Function YearsBetweenDates(ByVal StartDate As DateTime, _
        ByVal EndDate As DateTime) As Integer
        ' Returns the number of years between the passed dates
        If Month(EndDate) < Month(StartDate) Or _
          (Month(EndDate) = Month(StartDate) And _
          (EndDate.Day) < (StartDate.Day)) Then
            Return Year(EndDate) - Year(StartDate) - 1
        Else
            Return Year(EndDate) - Year(StartDate)
        End If
    End Function

End Class
