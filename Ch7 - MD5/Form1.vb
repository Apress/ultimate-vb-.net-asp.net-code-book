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
        Me.Button1.Size = New System.Drawing.Size(272, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Run sample MD5 code"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 134)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Implementing Powerful MD5 Encryption"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetMD5Hash(ByVal Text As String) As Byte()
        ' Generates an MD5 hash for the specified Text
        On Error Resume Next
        Dim objAscii As New System.Text.ASCIIEncoding()
        Dim bytHash As Byte() = _
           New System.Security.Cryptography.MD5CryptoServiceProvider(). _
           ComputeHash(objAscii.GetBytes(Text))
        Return bytHash
    End Function

    Public Function CheckMD5Hash(ByVal OriginalHash As Byte(), _
       ByVal Text As String) As Boolean
        ' Checks an MD5 hash against the specified Text
        ' Returns True if we have a match
        On Error Resume Next
        Dim objAscii As New System.Text.ASCIIEncoding()
        Dim intCount As Integer, blnMismatch As Boolean
        Dim bytHashToCompare As Byte() = GetMD5Hash(Text)
        If OriginalHash.Length <> bytHashToCompare.Length Then
            Return False
        Else
            For intCount = 0 To OriginalHash.Length
                If OriginalHash(intCount) <> bytHashToCompare(intCount) Then
                    Return False
                End If
            Next
            Return True
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bytHash() As Byte = GetMD5Hash("password")
        Dim blnMatch As Boolean = CheckMD5Hash(bytHash, "password")
        If blnMatch Then
            MessageBox.Show("We have a match - now look at the code to see what's happening!")
        Else
            MessageBox.Show("We don't have a match")
        End If
    End Sub
End Class
