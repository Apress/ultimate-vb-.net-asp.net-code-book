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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check whether this is a date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "01/01/2004"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 190)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Checking for a date, the .NET way!"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsDate(TextBox1.Text) Then
            MessageBox.Show("This is a date!")
        Else
            MessageBox.Show("This is NOT a date!")
        End If
    End Sub

    Public Function IsDate(ByVal DateIn As String) As Boolean
        Dim datDateTime As DateTime
        Dim blnIsDate As Boolean = True
        Try
            ' Attempt to parse date
            datDateTime = DateTime.Parse(DateIn)
        Catch e As FormatException
            ' Error parsing, return False
            blnIsDate = False
        End Try
        Return blnIsDate
    End Function

End Class
