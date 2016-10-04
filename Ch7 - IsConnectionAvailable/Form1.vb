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
        Me.Button1.Size = New System.Drawing.Size(336, 80)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Click me to find out!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 190)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Is an Internet connection available?"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ClickMe(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsConnectionAvailable() = True Then
            MessageBox.Show("You are online!")
        Else
            MessageBox.Show("You are offline!")
        End If
    End Sub

    Public Function IsConnectionAvailable() As Boolean
        ' Returns True if connection is available

        ' Replace www.yoursite.com with a site that
        ' is guaranteed to be online - perhaps your 
        ' corporate site, or microsoft.com
        Dim objUrl As New System.Uri("http://www.yoursite.com/")
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False
            If Not objResp Is Nothing Then objResp.Close()
            objWebReq = Nothing
            Return False
        End Try
    End Function

End Class
