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
        Me.Button1.Location = New System.Drawing.Point(80, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Test write/read registry code"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 174)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "How to Read and Write the Registry"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function ReadFromRegistry(ByVal Location As String, _
       ByVal Name As String) As String
        ' Returns a value from the registry
        Dim MyKey As Microsoft.Win32.RegistryKey
        MyKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Location)
        ReadFromRegistry = CType(MyKey.GetValue(Name), String)
        MyKey.Close()
    End Function

    Public Sub WriteToRegistry(ByVal Location As String, _
        ByVal Name As String, ByVal Data As String)
        ' Writes a value to the registry
        Dim MyKey As Microsoft.Win32.RegistryKey
        MyKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Location)
        MyKey.SetValue(Name, Data)
        MyKey.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WriteToRegistry("Software\White Cliff\MyApp", "Username", "John")
        MessageBox.Show(ReadFromRegistry("Software\White Cliff\MyApp", _
           "Username"))
    End Sub
End Class
