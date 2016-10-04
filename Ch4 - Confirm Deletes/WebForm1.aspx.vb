Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents DataSet11 As Ch4___Confirm_Deletes.DataSet1
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lblInfo As System.Web.UI.WebControls.Label

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DataSet11 = New Ch4___Confirm_Deletes.DataSet1()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pub_id, pub_name, city, state, country FROM publishers"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=.;initial catalog=pubs;persist security info=False;user id=sa;packet " & _
        "size=4096;password=;"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO publishers(pub_id, pub_name, city, state, country) VALUES (@pub_id, @" & _
        "pub_name, @city, @state, @country); SELECT pub_id, pub_name, city, state, countr" & _
        "y FROM publishers WHERE (pub_id = @pub_id)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
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
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
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
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_country", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "country", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_name", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "publishers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pub_id", "pub_id"), New System.Data.Common.DataColumnMapping("pub_name", "pub_name"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("country", "country")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-GB")
        Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            SqlDataAdapter1.Fill(DataSet11)
            DataGrid1.DataBind()
        End If
    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or _
            e.Item.ItemType = ListItemType.AlternatingItem Then
            If e.Item.Cells(0).Controls.Count > 0 Then
                If TypeOf (e.Item.Cells(0).Controls(0)) Is Button Then
                    Dim btnDelete As Button = CType(e.Item.Cells(0).Controls(0), Button)
                    btnDelete.Attributes("onclick") = _
                        "return confirm('Are you sure you wish to delete this record?');"
                End If
            End If
        End If
    End Sub

    Private Sub DataGrid1_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid1.DeleteCommand
        lblInfo.Text = "This sample does not actually delete records."
    End Sub
End Class
