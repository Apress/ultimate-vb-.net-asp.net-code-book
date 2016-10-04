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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 56)
        Me.Label1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(40, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(256, 23)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here to retrieve serial for C: drive"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 190)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabel1, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Retrieving a drive serial number"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function GetDriveSerial(ByVal DriveLetter As String) As String
        ' Returns the serial number of the specified drive
        ' ie, GetDriveSerial("c:")
        Dim strSelectText As String = "Win32_logicaldisk='" & DriveLetter & "'"
        Dim objMO As New System.Management.ManagementObject(strSelectText)
        objMO.Get()
        Return CType(objMO.Properties("VolumeSerialNumber").Value, String)
    End Function


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Label1.Text = GetDriveSerial("C:")
    End Sub
End Class
