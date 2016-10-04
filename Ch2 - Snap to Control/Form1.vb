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
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(192, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 64)
        Me.Button1.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(24, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here to snap!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 182)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabel1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Snapping to a Control"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SnapToControl(Button1)
    End Sub

    Public Sub SnapToControl(ByVal Control As Control)
        ' Snaps the cursor to the bottom middle of the passed control
        Dim objPoint As Point = Control.PointToScreen(New Point(0, 0))
        objPoint.X += (Control.Width / 2)
        objPoint.Y += ((Control.Height / 4) * 3)
        Cursor.Position = objPoint
    End Sub


End Class
