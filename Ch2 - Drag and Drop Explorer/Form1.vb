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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Filename As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Filename = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Filename})
        Me.ListView1.Location = New System.Drawing.Point(16, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(368, 296)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Drag and drop files from Explorer, or similar, onto this ListView control:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Filename
        '
        Me.Filename.Text = "File / folder"
        Me.Filename.Width = 300
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 342)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.ListView1})
        Me.Name = "Form1"
        Me.Text = "Drag and Drop from Windows Explorer"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub ListView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragOver
        ' As dragged over, check data is file drop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' Display the copy (or other) icon
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ListView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop
        ' Check this is a file drop
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            ' Retrieve list of files and loop through string array
            Dim strFiles() As String = e.Data.GetData(DataFormats.FileDrop)
            Dim intCount As Integer
            For intCount = 0 To strFiles.Length
                ListView1.Items.Add(strFiles(intCount), 0)
            Next
        End If
    End Sub
End Class
