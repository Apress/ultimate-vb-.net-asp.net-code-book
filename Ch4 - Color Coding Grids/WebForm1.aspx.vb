Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents DataSet11 As Ch4___Color_Coding_Grids.DataSet1
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DataSet11 = New Ch4___Color_Coding_Grids.DataSet1()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT job_id, job_desc, min_lvl, max_lvl FROM jobs"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO jobs(job_desc, min_lvl, max_lvl) VALUES (@job_desc, @min_lvl, @max_lv" & _
        "l); SELECT job_id, job_desc, min_lvl, max_lvl FROM jobs WHERE (job_id = @@IDENTI" & _
        "TY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_desc", System.Data.SqlDbType.VarChar, 50, "job_desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_lvl", System.Data.SqlDbType.TinyInt, 1, "min_lvl"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_lvl", System.Data.SqlDbType.TinyInt, 1, "max_lvl"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE jobs SET job_desc = @job_desc, min_lvl = @min_lvl, max_lvl = @max_lvl WHER" & _
        "E (job_id = @Original_job_id) AND (job_desc = @Original_job_desc) AND (max_lvl =" & _
        " @Original_max_lvl) AND (min_lvl = @Original_min_lvl); SELECT job_id, job_desc, " & _
        "min_lvl, max_lvl FROM jobs WHERE (job_id = @job_id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_desc", System.Data.SqlDbType.VarChar, 50, "job_desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_lvl", System.Data.SqlDbType.TinyInt, 1, "min_lvl"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_lvl", System.Data.SqlDbType.TinyInt, 1, "max_lvl"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_id", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_id", System.Data.SqlDbType.SmallInt, 2, "job_id"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM jobs WHERE (job_id = @Original_job_id) AND (job_desc = @Original_job_" & _
        "desc) AND (max_lvl = @Original_max_lvl) AND (min_lvl = @Original_min_lvl)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_id", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_lvl", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=.;initial catalog=pubs;persist security info=False;user id=sa;packet " & _
        "size=4096;password=;"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "jobs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("job_id", "job_id"), New System.Data.Common.DataColumnMapping("job_desc", "job_desc"), New System.Data.Common.DataColumnMapping("min_lvl", "min_lvl"), New System.Data.Common.DataColumnMapping("max_lvl", "max_lvl")})})
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
        SqlDataAdapter1.Fill(DataSet11)
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or _
            e.Item.ItemType = ListItemType.AlternatingItem Then
            If CType(e.Item.Cells(3).Text, Integer) > 230 Then
                e.Item.Cells(3).BackColor = Color.Plum
                e.Item.Cells(3).ForeColor = Color.White
                e.Item.Cells(3).Font.Bold = True
            Else
                e.Item.BackColor = Color.WhiteSmoke
                e.Item.BorderStyle = BorderStyle.Dotted
            End If
        End If
    End Sub
End Class
