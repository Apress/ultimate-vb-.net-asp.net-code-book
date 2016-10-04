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
        Me.Button1.Location = New System.Drawing.Point(328, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Draw sample"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 238)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Drawing with Windows Forms"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Get Graphics object, our "sheet of drawing paper"
        Dim objGraphics As System.Drawing.Graphics = Me.CreateGraphics

        ' Create new Pen, color blue, width 10
        Dim objPen As New Pen(Color.Blue, 10)
        ' Draw line using pen from 
        ' 45 across, 45 down to 95 across, 95 down
        objGraphics.DrawLine(objPen, 45, 45, 95, 95)

        ' Draw arc, this time using built-in green pen
        ' 8 across, 10 down to 30 across, 30 down
        ' with a 90 degree start angle and 180 degree sweep
        objGraphics.DrawArc(Pens.Green, 8, 10, 30, 30, 90, 180)

        ' Create new Brush-based object, color purple
        Dim objBrush As New SolidBrush(Color.Purple)
        ' Draw rectangle area using brush
        ' start at 100 across, 100 down,
        ' carry on for 50 across, 50 down
        objGraphics.FillRectangle(objBrush, 100, 100, 50, 50)

        ' Draw ellipse, this time using built-in orange brush
        objGraphics.FillEllipse(Brushes.Orange, 10, 10, 30, 30)

    End Sub
End Class
