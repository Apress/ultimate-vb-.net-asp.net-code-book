Imports Microsoft.Win32

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click to retrieve"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter an extension:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(path will appear here)"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 174)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.TextBox1, Me.Label1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Retrieving the program associated with a file extension"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strPath As String = GetAssociatedProgram(TextBox1.Text)
        If strPath <> "" Then
            Label2.Text = strPath
        Else
            Label2.Text = "No associated application found!"
        End If
    End Sub

    Public Function GetAssociatedProgram(ByVal FileExtension As String) As String
        ' Returns the application associated with the specified FileExtension
        ' ie, path\denenv.exe for "VB" files
        Dim objExtReg As Microsoft.Win32.RegistryKey = _
            Microsoft.Win32.Registry.ClassesRoot
        Dim objAppReg As Microsoft.Win32.RegistryKey = _
            Microsoft.Win32.Registry.ClassesRoot
        Dim strExtValue As String
        Try
            ' Add trailing period if doesn't exist
            If FileExtension.Substring(0, 1) <> "." Then _
                FileExtension = "." & FileExtension
            ' Open registry areas containing launching app details
            objExtReg = objExtReg.OpenSubKey(FileExtension.Trim)
            strExtValue = objExtReg.GetValue("")
            objAppReg = objAppReg.OpenSubKey(strExtValue & "\shell\open\command")
            ' Parse out, tidy up and return result
            Dim SplitArray() As String
            SplitArray = Split(objAppReg.GetValue(Nothing), """")
            If SplitArray(0).Trim.Length > 0 Then
                Return SplitArray(0).Replace("%1", "")
            Else
                Return SplitArray(1).Replace("%1", "")
            End If
        Catch
            Return ""
        End Try
    End Function

End Class
