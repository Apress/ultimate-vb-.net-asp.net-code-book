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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 40)
        Me.Label2.TabIndex = 5
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Click to roll the die..."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(176, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Roll!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 118)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Random Numbers… That Work!"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Dim objRandom As New System.Random( _
        CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))

    Public Function GetRandomNumber( _
       Optional ByVal Low As Integer = 1, _
       Optional ByVal High As Integer = 100) As Integer
        ' Returns a random number,
        ' between the optional Low and High parameters
        Return objRandom.Next(Low, High + 1)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intDiceRoll As Integer
        intDiceRoll = GetRandomNumber(1, 6)
        Label2.Text = "Rolled " & intDiceRoll.ToString
    End Sub
End Class
