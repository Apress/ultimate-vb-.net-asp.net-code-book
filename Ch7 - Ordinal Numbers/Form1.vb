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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number..."
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(160, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 118)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.TextBox1, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "1st, 2nd, 3rd: Using Ordinal Numbers in your App"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetOrdinal(ByVal Number As Integer) As String
        ' Accepts an integer, returns the ordinal suffix
        
        ' Handles special case three digit numbers ending
        ' with 11, 12 or 13 - ie, 111th, 112th, 113th, 211th, et al
        If CType(Number, String).Length > 2 Then
            Dim intEndNum As Integer = CType(CType(Number, String). _
                Substring(CType(Number, String).Length - 2, 2), Integer)
            If intEndNum >= 11 And intEndNum <= 13 Then
                Select Case intEndNum
                    Case 11, 12, 13
                        Return "th"
                End Select
            End If
        End If

        If Number >= 21 Then
            ' Handles 21st, 22nd, 23rd, et al
            Select Case CType(Number.ToString.Substring( _
                Number.ToString.Length - 1, 1), Integer)
                Case 1
                    Return "st"
                Case 2
                    Return "nd"
                Case 3
                    Return "rd"
                Case 0, 4 To 9
                    Return "th"
            End Select
        Else
            ' Handles 1st to 20th
            Select Case Number
                Case 1
                    Return "st"
                Case 2
                    Return "nd"
                Case 3
                    Return "rd"
                Case 4 To 20
                    Return "th"
            End Select
        End If
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            Label2.Text = "?"
        Else
            Label2.Text = TextBox1.Text & GetOrdinal(TextBox1.Text)
        End If
    End Sub
End Class
