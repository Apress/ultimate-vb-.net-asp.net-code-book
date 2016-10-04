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
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(120, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sample Gradient App!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(400, 182)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Add an Exciting Gradient Backdrop, in Code!"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DrawFormGradient(ByVal TopColor As Color, ByVal BottomColor As Color)
        ' Draws a gradient using the specified colors
        ' on the entire page
        Dim objBrush As New Drawing2D.LinearGradientBrush _
            (Me.DisplayRectangle, _
            TopColor, _
            BottomColor, _
            Drawing2D.LinearGradientMode.Vertical)
        Dim objGraphics As Graphics = Me.CreateGraphics()
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        DrawFormGradient(Color.Blue, Color.AliceBlue)
    End Sub
End Class
