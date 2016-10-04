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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(400, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click here to generate a five-character memorable password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 150)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "How To Generate Memorable Passwords, Automatically"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function GeneratePassword(ByVal Length As Integer) As String
        ' Creates a memorable password of the specified Length
        Dim blnOnVowel As Boolean
        Dim strTempLetter As String
        Dim strPassword As String
        Dim intCount As Integer
        For intCount = 1 To Length
            If blnOnVowel = False Then
                ' Choose a nice consonant - no C, X, Z, or Q
                strTempLetter = CType(Choose(CType(GetRandomNumber(1, 17), Double), _
                    "B", "D", "F", "G", "H", "J", "K", "L", "M", _
                    "N", "P", "R", "S", "T", "V", "W", "Y"), String)
                ' Append it to the password string
                strPassword += strTempLetter
                ' Swich to vowel mode
                blnOnVowel = True
            Else
                ' Choose a vowel
                strTempLetter = CType(Choose(CType(GetRandomNumber(1, 5), Double), _
                    "A", "E", "I", "O", "U"), String)
                ' Append it to the password string
                strPassword += strTempLetter
                ' Switch back again, ready for next loop round
                blnOnVowel = False
            End If
        Next
        Return strPassword
    End Function

    Dim objRandom As New System.Random(CType((System.DateTime.Now.Ticks _
        Mod System.Int32.MaxValue), Integer))
    Public Function GetRandomNumber(Optional ByVal Low As Integer = 1, _
        Optional ByVal High As Integer = 100) As Integer
        ' Returns a random number,
        ' between the optional Low and High parameters
        Return objRandom.Next(Low, High + 1)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = GeneratePassword(5)
    End Sub
End Class
