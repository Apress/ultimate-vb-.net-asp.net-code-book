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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(64, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(424, 152)
        Me.DataGrid1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(424, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Grab using named ranges"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 262)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.DataGrid1})
        Me.Name = "Form1"
        Me.Text = "Sample Excel Worksheet Reading!"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function GetDataFromExcel(ByVal FileName As String, _
     ByVal RangeName As String) As System.Data.DataSet
        ' Returns a DataSet containing information from 
        ' RangeName in the passed Excel worksheet
        Try
            Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & FileName & ";Extended Properties=Excel 8.0;"
            Dim objConn As New System.Data.OleDb.OleDbConnection(strConn)
            objConn.Open()
            ' Create objects ready to grab data
            Dim objCmd As New System.Data.OleDb.OleDbCommand( _
                "SELECT * FROM " & RangeName, objConn)
            Dim objDA As New System.Data.OleDb.OleDbDataAdapter()
            objDA.SelectCommand = objCmd
            ' Fill DataSet
            Dim objDS As New System.Data.DataSet()
            objDA.Fill(objDS)
            ' Cleanup and return DataSet
            objConn.Close()
            Return objDS
        Catch
            ' Possible errors include Excel file
            ' already open and locked, et al.
            Return Nothing
        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGrid1.DataSource = GetDataFromExcel(Application.StartupPath & "\MyTestWorkbook.xls", _
            "SampleNamedRange").Tables(0)
    End Sub

End Class
