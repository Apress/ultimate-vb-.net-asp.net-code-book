Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents MyConnection As System.Data.SqlClient.SqlConnection
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents MyDataSet As Ch4___Web_Grid.Publisher
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents MyDataAdapter As System.Data.SqlClient.SqlDataAdapter

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.MyConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.MyDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.MyDataSet = New Ch4___Web_Grid.Publisher()
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pub_id, pub_name, city, state, country FROM publishers"
        Me.SqlSelectCommand1.Connection = Me.MyConnection
        '
        'MyConnection
        '
        Me.MyConnection.ConnectionString = "data source=.;initial catalog=pubs;persist security info=False;user id=sa;packet " & _
        "size=4096;password=;"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO publishers(pub_id, pub_name, city, state, country) VALUES (@pub_id, @" & _
        "pub_name, @city, @state, @country); SELECT pub_id, pub_name, city, state, countr" & _
        "y FROM publishers WHERE (pub_id = @pub_id)"
        Me.SqlInsertCommand1.Connection = Me.MyConnection
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.VarChar, 4, "pub_id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pub_name", System.Data.SqlDbType.VarChar, 40, "pub_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 20, "city"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.VarChar, 30, "country"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE publishers SET pub_id = @pub_id, pub_name = @pub_name, city = @city, state" & _
        " = @state, country = @country WHERE (pub_id = @Original_pub_id) AND (city = @Ori" & _
        "ginal_city OR @Original_city IS NULL AND city IS NULL) AND (country = @Original_" & _
        "country OR @Original_country IS NULL AND country IS NULL) AND (pub_name = @Origi" & _
        "nal_pub_name OR @Original_pub_name IS NULL AND pub_name IS NULL) AND (state = @O" & _
        "riginal_state OR @Original_state IS NULL AND state IS NULL); SELECT pub_id, pub_" & _
        "name, city, state, country FROM publishers WHERE (pub_id = @pub_id)"
        Me.SqlUpdateCommand1.Connection = Me.MyConnection
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.VarChar, 4, "pub_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pub_name", System.Data.SqlDbType.VarChar, 40, "pub_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 20, "city"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.VarChar, 30, "country"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_country", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "country", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_name", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM publishers WHERE (pub_id = @Original_pub_id) AND (city = @Original_ci" & _
        "ty OR @Original_city IS NULL AND city IS NULL) AND (country = @Original_country " & _
        "OR @Original_country IS NULL AND country IS NULL) AND (pub_name = @Original_pub_" & _
        "name OR @Original_pub_name IS NULL AND pub_name IS NULL) AND (state = @Original_" & _
        "state OR @Original_state IS NULL AND state IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.MyConnection
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_country", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "country", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_name", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        '
        'MyDataAdapter
        '
        Me.MyDataAdapter.DeleteCommand = Me.SqlDeleteCommand1
        Me.MyDataAdapter.InsertCommand = Me.SqlInsertCommand1
        Me.MyDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.MyDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "publishers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pub_id", "pub_id"), New System.Data.Common.DataColumnMapping("pub_name", "pub_name"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("country", "country")})})
        Me.MyDataAdapter.UpdateCommand = Me.SqlUpdateCommand1
        '
        'MyDataSet
        '
        Me.MyDataSet.DataSetName = "Publisher"
        Me.MyDataSet.Locale = New System.Globalization.CultureInfo("en-GB")
        Me.MyDataSet.Namespace = "http://www.tempuri.org/Publisher.xsd"
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' TODO: Change the ConnectionString property of MyConnection to get sample to work correctly

        If Not IsPostBack Then
            MyDataAdapter.Fill(MyDataSet)
            MyDataGrid.DataSource = MyDataSet
            MyDataGrid.DataBind()
            DataSave(MyDataSet)
            ' The DataSave function will be added later.
            ' Remove this line and stop here if you want
            ' a read-only DataGrid
        End If
    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDataGrid.SelectedIndexChanged
        Dim intCount As Integer
        For intCount = 1 To MyDataGrid.Items.Count
            MyDataGrid.Items(intCount - 1).BorderStyle = BorderStyle.Groove
        Next
        MyDataGrid.SelectedItem.BorderStyle = BorderStyle.Dashed
    End Sub

    Public Sub DataSave(ByVal DataSet As DataSet)
        If DataExists() Then
            ViewState.Item("__Data") = DataSet
        Else
            ViewState.Add("__Data", DataSet)
        End If
    End Sub

    Public Function DataRetrieve() As DataSet
        Return CType(ViewState.Item("__Data"), DataSet)
    End Function

    Public Function DataExists() As Boolean
        If Not ViewState.Item("__Data") Is Nothing Then Return True
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Code to respond to the Click event of the ADD button:
        ' Desc: Adds a new row to the DataSet, rebinds to the
        ' DataGrid, then makes the row editable
        If DataExists() = False Then Exit Sub
        MyDataSet = DataRetrieve()
        Dim rowNew As System.Data.DataRow = MyDataSet.Tables(0).NewRow
        ' Enter sample values for non-null fields here
        ' ie, rowNew.Item("uniqueTag") = "sample"
        ' Alternatively, use separate text boxes for input
        ' and add field values in code, as above.

        rowNew.Item("pub_id") = 0
        ' Note: This database requires the pub_id field
        '       to be within a specified range. When changing
        '       this default of zero, try specifying a new ID
        '       among the existing ranges - ie, 9985

        MyDataSet.Tables(0).Rows.Add(rowNew)
        MyDataGrid.EditItemIndex = MyDataGrid.Items.Count
        MyDataGrid.DataSource = MyDataSet
        MyDataGrid.DataBind()
        DataSave(MyDataSet)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Code to respond to the Click event of the DELETE button:
        ' Desc: Deletes the selected row, updates the DataSet, then rebinds
        If DataExists() = False Then Exit Sub
        If MyDataGrid.SelectedIndex = -1 Then Exit Sub
        MyDataSet = DataRetrieve()
        MyDataSet.Tables(0).Rows(MyDataGrid.SelectedIndex).Delete()
        MyDataGrid.EditItemIndex = -1
        MyDataGrid.SelectedIndex = -1
        MyDataGrid.DataSource = MyDataSet
        MyDataGrid.DataBind()
        DataSave(MyDataSet)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Code to respond to the Click event of the EDIT button:
        ' Desc: Makes the selected row editable, then rebinds
        If DataExists() = False Then Exit Sub
        If MyDataGrid.SelectedIndex = -1 Then Exit Sub
        Dim MyDataSet As DataSet = DataRetrieve()
        MyDataGrid.DataSource = MyDataSet
        MyDataGrid.EditItemIndex = MyDataGrid.SelectedIndex
        MyDataGrid.DataBind()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Code to respond to the Click event of the OK button:
        ' Desc: Cycles through the TextBox controls used during a standard edit,
        ' puts the values back in the DataSet, then rebinds. Add error handling
        ' as appropriate.
        ' NOTE: This code relies on the first column being a selection (>) button
        ' (it starts counting the cells from position 1, not 0). If you remove that
        ' button, you may have to change this code.
        If DataExists() = False Then Exit Sub
        If MyDataGrid.EditItemIndex = -1 Then Exit Sub
        Dim intCount As Integer
        Dim MyDataSet As DataSet = DataRetrieve()
        With MyDataGrid
            For intCount = 1 To .Items(.EditItemIndex).Cells.Count
                If intCount = .Items(.EditItemIndex).Cells.Count Then Exit For
                ' Check that a control exists in this position
                If .Items(.EditItemIndex).Cells(intCount).Controls.Count Then
                    ' Check for a standard TextBox
                    If TypeOf (.Items(.EditItemIndex).Cells(intCount).Controls(0)) _
                        Is TextBox Then
                        Dim strValue As String = CType(.Items(.EditItemIndex). _
                            Cells(intCount).Controls(0), TextBox).Text
                        If strValue <> "" Then
                            ' This isn't null, so store value
                            MyDataSet.Tables(0).Rows(.EditItemIndex).Item( _
                                intCount - 1) = strValue
                        Else
                            ' Treat empty value as null
                            MyDataSet.Tables(0).Rows(.EditItemIndex).Item( _
                                intCount - 1) = System.DBNull.Value
                        End If
                    End If
                End If
            Next
            .SelectedIndex = -1
            .EditItemIndex = -1
            DataSave(MyDataSet)
            .DataSource = MyDataSet
            .DataBind()
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' Code to respond to the Click event of the CANCEL button:
        ' Desc: Used to cancel an edit. Deselects an selected rows and
        ' exists the edit mode, then rebinds.
        If DataExists() = False Then Exit Sub
        MyDataGrid.SelectedIndex = -1
        MyDataGrid.EditItemIndex = -1
        MyDataGrid.DataSource = DataRetrieve()
        MyDataGrid.DataBind()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' Code to respond to the Click event of the UPDATE button:
        ' Desc: Updates the underlying database, then rebinds.
        ' Add error handling code as appropriate.
        If DataExists() = False Then Exit Sub
        MyDataAdapter.Update(DataRetrieve)
        MyDataGrid.DataSource = DataRetrieve()
        MyDataGrid.DataBind()
    End Sub
End Class
