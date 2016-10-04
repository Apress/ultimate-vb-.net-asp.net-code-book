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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click button to start"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "maxsql001.maximumasp.com"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(72, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server address:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Click here to check whether above server is online"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 182)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label2, Me.TextBox1, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Ch4 - Simple check to see whether SQL Server is online"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function IsSQLServerOnline(ByVal ServerAddress As String) As Boolean
        ' Tests an SQL Server connection by name or IP address

        Try
            ' Attempt to get server address
            Dim objIPHost As New System.Net.IPHostEntry()
            objIPHost = System.Net.Dns.Resolve(ServerAddress)
            Dim objAddress As System.Net.IPAddress
            objAddress = objIPHost.AddressList(0)
            ' Connect to port 1433, most common SQL Server
            ' port. If your target is different, change here
            Dim objTCP As System.Net.Sockets.TcpClient = _
                New System.Net.Sockets.TcpClient()
            objTCP.Connect(objAddress, 1433)
            ' No problems (hurrah!)
            ' Close and cleanup
            objTCP.Close()
            objTCP = Nothing
            objAddress = Nothing
            objIPHost = Nothing
            ' Return success
            Return True

        Catch ex As Exception
            ' Server unavailable, return fail value
            Return False
        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If IsSQLServerOnline(TextBox1.Text) Then
            Label1.Text = "Can connect to server!"
        Else
            Label1.Text = "Server not available!"
        End If

    End Sub
End Class
