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
        Me.Button1.Location = New System.Drawing.Point(56, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(344, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click here to add a couple of sample Favorites to your machine!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 150)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Adding a Web Shortcut to the Favorites"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CreateShortcut("Karl Moore.com", "http://www.karlmoore.com/")
        CreateShortcut("White Cliff Computing Ltd", "http://www.whitecliff.net/")
    End Sub

    Public Sub CreateShortcut(ByVal Title As String, ByVal URL As String)
        ' Creates a shortcut in the users Favorites folder
        Dim strFavoriteFolder As String
        ' Retrieve the favorite folder
        strFavoriteFolder = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.Favorites)
        ' Create shortcut file, based on Title
        Dim objWriter As System.IO.StreamWriter = _
            System.IO.File.CreateText(strFavoriteFolder & _
            "\" & Title & ".url")
        ' Write URL to file
        objWriter.WriteLine("[InternetShortcut]")
        objWriter.WriteLine("URL=" & URL)
        ' Close file
        objWriter.Close()
    End Sub

End Class
