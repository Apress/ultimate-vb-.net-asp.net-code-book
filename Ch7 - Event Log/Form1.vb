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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Run sample event log code"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 150)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Putting Messages in the Event Log"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function WriteToEventLog(ByVal Entry As String, _
        Optional ByVal AppName As String = "VB.NET Application", _
        Optional ByVal EventType As _
        EventLogEntryType = EventLogEntryType.Information, _
        Optional ByVal LogName As String = "Application") As Boolean
        ' Writes an entry to the Event Log
        Dim objEventLog As New EventLog()
        Try
            ' Register app as an Event Source
            If Not objEventLog.SourceExists(AppName) Then
                objEventLog.CreateEventSource(AppName, LogName)
            End If
            objEventLog.Source = AppName
            ' Send entry
            objEventLog.WriteEntry(Entry, EventType)
            Return True
        Catch Ex As Exception
            Return False
        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Simple event log addition
        WriteToEventLog("Application has failed to find STARTUP.INI")

        ' Slightly more complex sample
        WriteToEventLog("Unable to parse request LOGON", _
            "Authenticator", EventLogEntryType.Error, "Special Log")
    End Sub
End Class
