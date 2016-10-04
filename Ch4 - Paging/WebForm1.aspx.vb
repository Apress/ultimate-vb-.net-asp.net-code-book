Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents MyDataSet As Ch4___Paging.DataSet1
    Protected WithEvents MyDataAdapter As System.Data.SqlClient.SqlDataAdapter

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.MyDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.MyDataSet = New Ch4___Paging.DataSet1()
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MyDataSet.DataSetName = "DataSet1"
        Me.MyDataSet.Locale = New System.Globalization.CultureInfo("en-GB")
        Me.MyDataSet.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            MyDataAdapter.Fill(MyDataSet)
            MyDataGrid.DataBind()
        End If
    End Sub

    Private Sub MyDataGrid_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles MyDataGrid.PageIndexChanged
        MyDataGrid.CurrentPageIndex = e.NewPageIndex
        ' Bind your data again here. You could load DataSet
        ' from ViewState, database, etc. For example:
        MyDataAdapter.Fill(MyDataSet)
        MyDataGrid.DataBind()
    End Sub
End Class
