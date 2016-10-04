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
        Me.Button1.Location = New System.Drawing.Point(96, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click here to retrieve three tables from the local SQL Server ""pubs"" database"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 142)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Simple example demonstrating multi-table DataSet!"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim MyDataSet As New DataSet()
        Dim Tables(2) As String
        Tables(0) = "authors" : Tables(1) = "sales" : Tables(2) = "titles"
        MyDataSet = GetDataSet("data source=localhost;initial catalog=pubs;" & _
            "persist security info=False;user id=sa;pwd=", Tables)

        MessageBox.Show("DataSet successfully populated!")

    End Sub

    Public Function GetDataSet(ByVal ConnectionString As String, _
        ByRef Tables() As String) As System.Data.DataSet

        ' Create connection, command object and empty DataSet
        Dim objConn As New System.Data.SqlClient.SqlConnection(ConnectionString)
        Dim objCmd As New System.Data.SqlClient.SqlCommand()
        objCmd.Connection = objConn
        objCmd.CommandType = System.Data.CommandType.Text
        Dim objDS As New System.Data.DataSet()

        Try
            ' Create new DataAdapter
            Dim objDA As New System.Data.SqlClient.SqlDataAdapter(objCmd)
            objDA.SelectCommand = objCmd
            ' Open connection
            objConn.Open()
            ' Populate the DataSet with specified tables
            Dim intCount As Integer
            For intCount = 0 To Tables.GetUpperBound(0)
                objCmd.CommandText = "SELECT * FROM " & Tables(intCount)
                objDA.Fill(objDS, Tables(intCount))
            Next

        Catch e As Exception
            ' Calling code must check for thrown errors
            Throw e

        Finally
            ' Clean up
            objConn.Close()
        End Try

        Return objDS

    End Function

End Class
