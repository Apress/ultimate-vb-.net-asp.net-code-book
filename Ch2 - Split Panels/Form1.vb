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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(120, 261)
        Me.TreeView1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(120, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(232, 261)
        Me.ListView1.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(120, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 261)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 261)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Splitter1, Me.ListView1, Me.TreeView1})
        Me.Name = "Form1"
        Me.Text = "Creating Split Panels, Explorer-Style"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Add("Example entry")
        ListView1.Items.Add("Sample data")
    End Sub
End Class
