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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Run the final .EXE version of this application."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 157)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PrevInstance() = True Then
            ' Get all previous instances
            Dim Processes() As Process
            Processes = Diagnostics.Process.GetProcessesByName( _
                Diagnostics.Process.GetCurrentProcess.ProcessName)
            ' Display message
            MessageBox.Show("A previous instance of this program is " & _
                "running. It's about to be activated...")
            ' Activate the first instance
            AppActivate(Processes(0).Id)
            ' Exit the current instance
            Application.Exit()
        End If
    End Sub

    Public Function PrevInstance() As Boolean
        If Diagnostics.Process.GetProcessesByName _
            (Diagnostics.Process.GetCurrentProcess.ProcessName).Length > 1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
