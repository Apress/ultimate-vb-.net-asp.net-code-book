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
        Me.Button1.Location = New System.Drawing.Point(56, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Retrieve my IP address!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 158)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "How To Retrieve Your IP Address – And Why You May Want To"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objEntry As System.Net.IPHostEntry = _
            System.Net.Dns.GetHostByName( _
            System.Net.Dns.GetHostName)
        Dim strIP As String = CType( _
            objEntry.AddressList.GetValue(0), _
            System.Net.IPAddress).ToString
        MessageBox.Show("Your IP address is " & strIP)
    End Sub
End Class
