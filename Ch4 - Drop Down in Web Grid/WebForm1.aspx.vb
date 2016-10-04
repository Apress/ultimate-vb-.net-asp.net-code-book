Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents ChildDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents ParentDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents MyDataSet As Ch4___Drop_Down_in_Web_Grid.DataSet1

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ParentDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.MyDataSet = New Ch4___Drop_Down_in_Web_Grid.DataSet1()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ChildDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date FROM emplo" & _
        "yee"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=.;initial catalog=pubs;persist security info=False;user id=sa;packet " & _
        "size=4096;password=;"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO employee(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_d" & _
        "ate) VALUES (@emp_id, @fname, @minit, @lname, @job_id, @job_lvl, @pub_id, @hire_" & _
        "date); SELECT emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date FR" & _
        "OM employee WHERE (emp_id = @emp_id)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@emp_id", System.Data.SqlDbType.VarChar, 9, "emp_id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.VarChar, 20, "fname"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@minit", System.Data.SqlDbType.VarChar, 1, "minit"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.VarChar, 30, "lname"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_id", System.Data.SqlDbType.SmallInt, 2, "job_id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_lvl", System.Data.SqlDbType.TinyInt, 1, "job_lvl"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.VarChar, 4, "pub_id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hire_date", System.Data.SqlDbType.DateTime, 8, "hire_date"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE employee SET emp_id = @emp_id, fname = @fname, minit = @minit, lname = @ln" & _
        "ame, job_id = @job_id, job_lvl = @job_lvl, pub_id = @pub_id, hire_date = @hire_d" & _
        "ate WHERE (emp_id = @Original_emp_id) AND (fname = @Original_fname) AND (hire_da" & _
        "te = @Original_hire_date) AND (job_id = @Original_job_id) AND (job_lvl = @Origin" & _
        "al_job_lvl OR @Original_job_lvl IS NULL AND job_lvl IS NULL) AND (lname = @Origi" & _
        "nal_lname) AND (minit = @Original_minit OR @Original_minit IS NULL AND minit IS " & _
        "NULL) AND (pub_id = @Original_pub_id); SELECT emp_id, fname, minit, lname, job_i" & _
        "d, job_lvl, pub_id, hire_date FROM employee WHERE (emp_id = @emp_id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@emp_id", System.Data.SqlDbType.VarChar, 9, "emp_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.VarChar, 20, "fname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@minit", System.Data.SqlDbType.VarChar, 1, "minit"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.VarChar, 30, "lname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_id", System.Data.SqlDbType.SmallInt, 2, "job_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_lvl", System.Data.SqlDbType.TinyInt, 1, "job_lvl"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.VarChar, 4, "pub_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hire_date", System.Data.SqlDbType.DateTime, 8, "hire_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_emp_id", System.Data.SqlDbType.VarChar, 9, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "emp_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_hire_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hire_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_id", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_lname", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_minit", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "minit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM employee WHERE (emp_id = @Original_emp_id) AND (fname = @Original_fna" & _
        "me) AND (hire_date = @Original_hire_date) AND (job_id = @Original_job_id) AND (j" & _
        "ob_lvl = @Original_job_lvl OR @Original_job_lvl IS NULL AND job_lvl IS NULL) AND" & _
        " (lname = @Original_lname) AND (minit = @Original_minit OR @Original_minit IS NU" & _
        "LL AND minit IS NULL) AND (pub_id = @Original_pub_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_emp_id", System.Data.SqlDbType.VarChar, 9, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "emp_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_hire_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hire_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_id", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_lname", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_minit", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "minit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing))
        '
        'ParentDataAdapter
        '
        Me.ParentDataAdapter.DeleteCommand = Me.SqlDeleteCommand1
        Me.ParentDataAdapter.InsertCommand = Me.SqlInsertCommand1
        Me.ParentDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.ParentDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("emp_id", "emp_id"), New System.Data.Common.DataColumnMapping("fname", "fname"), New System.Data.Common.DataColumnMapping("minit", "minit"), New System.Data.Common.DataColumnMapping("lname", "lname"), New System.Data.Common.DataColumnMapping("job_id", "job_id"), New System.Data.Common.DataColumnMapping("job_lvl", "job_lvl"), New System.Data.Common.DataColumnMapping("pub_id", "pub_id"), New System.Data.Common.DataColumnMapping("hire_date", "hire_date")})})
        Me.ParentDataAdapter.UpdateCommand = Me.SqlUpdateCommand1
        '
        'MyDataSet
        '
        Me.MyDataSet.DataSetName = "DataSet1"
        Me.MyDataSet.Locale = New System.Globalization.CultureInfo("en-GB")
        Me.MyDataSet.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT job_id, job_desc, min_lvl, max_lvl FROM jobs"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO jobs(job_desc, min_lvl, max_lvl) VALUES (@job_desc, @min_lvl, @max_lv" & _
        "l); SELECT job_id, job_desc, min_lvl, max_lvl FROM jobs WHERE (job_id = @@IDENTI" & _
        "TY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_desc", System.Data.SqlDbType.VarChar, 50, "job_desc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_lvl", System.Data.SqlDbType.TinyInt, 1, "min_lvl"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_lvl", System.Data.SqlDbType.TinyInt, 1, "max_lvl"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE jobs SET job_desc = @job_desc, min_lvl = @min_lvl, max_lvl = @max_lvl WHER" & _
        "E (job_id = @Original_job_id) AND (job_desc = @Original_job_desc) AND (max_lvl =" & _
        " @Original_max_lvl) AND (min_lvl = @Original_min_lvl); SELECT job_id, job_desc, " & _
        "min_lvl, max_lvl FROM jobs WHERE (job_id = @job_id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_desc", System.Data.SqlDbType.VarChar, 50, "job_desc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_lvl", System.Data.SqlDbType.TinyInt, 1, "min_lvl"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_lvl", System.Data.SqlDbType.TinyInt, 1, "max_lvl"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_id", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@job_id", System.Data.SqlDbType.SmallInt, 2, "job_id"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM jobs WHERE (job_id = @Original_job_id) AND (job_desc = @Original_job_" & _
        "desc) AND (max_lvl = @Original_max_lvl) AND (min_lvl = @Original_min_lvl)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_id", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_job_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "job_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_lvl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_lvl", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_lvl", System.Data.DataRowVersion.Original, Nothing))
        '
        'ChildDataAdapter
        '
        Me.ChildDataAdapter.DeleteCommand = Me.SqlDeleteCommand2
        Me.ChildDataAdapter.InsertCommand = Me.SqlInsertCommand2
        Me.ChildDataAdapter.SelectCommand = Me.SqlSelectCommand2
        Me.ChildDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "jobs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("job_id", "job_id"), New System.Data.Common.DataColumnMapping("job_desc", "job_desc"), New System.Data.Common.DataColumnMapping("min_lvl", "min_lvl"), New System.Data.Common.DataColumnMapping("max_lvl", "max_lvl")})})
        Me.ChildDataAdapter.UpdateCommand = Me.SqlUpdateCommand2
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Do initial data fill
        If Not IsPostBack Then
            ParentDataAdapter.Fill(MyDataSet)
            ChildDataAdapter.Fill(MyDataSet)
            MyDataGrid.DataBind()
        End If
    End Sub

    Private Sub MyDataGrid_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles MyDataGrid.ItemDataBound
        ' If this is a valid item...
        If e.Item.ItemType = ListItemType.AlternatingItem Or _
           e.Item.ItemType = ListItemType.Item Then
            ' Find the dropdown containing our list of options
            Dim ddl As DropDownList = _
               CType(e.Item.FindControl("ddl1"), DropDownList)
            ' Retrieve the foreign key value
            Dim intForeignKey As Integer = _
                e.Item.Cells(5).Text
            ' Select the correct entry in the dropdown
            ddl.SelectedIndex = _
               ddl.Items.IndexOf( _
               ddl.Items.FindByValue(intForeignKey))
        End If
    End Sub

    Private Sub MyDataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles MyDataGrid.EditCommand
        ' Select the current row for 'edit mode'
        MyDataGrid.EditItemIndex = e.Item.ItemIndex
        ' Refill DataSets with information
        ParentDataAdapter.Fill(MyDataSet)
        ChildDataAdapter.Fill(MyDataSet)
        ' Rebind data
        MyDataGrid.DataBind()
        ' Select default dropdown option, as earlier
        Dim ddl As DropDownList = _
            CType(MyDataGrid.Items(MyDataGrid.EditItemIndex). _
            FindControl("ddl2"), DropDownList)
        ddl.SelectedIndex = _
            ddl.Items.IndexOf( _
            ddl.Items.FindByValue(e.Item.Cells(5).Text))
    End Sub

    Private Sub MyDataGrid_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles MyDataGrid.UpdateCommand

        ' This event runs when the Update button is clicked

        ' Step one: Put dropdown list value into foreign key field
        CType(e.Item.Cells(5).Controls(0), TextBox).Text = _
            CType(e.Item.FindControl("ddl2"), DropDownList).SelectedItem.Value()

        ' Step two: Fill DataSet and identify row to edit
        ParentDataAdapter.Fill(MyDataSet)
        ChildDataAdapter.Fill(MyDataSet)
        Dim objEditedRow As DataRow = MyDataSet.Tables(0).Rows.Find( _
            CType(e.Item.Cells(1).Controls(0), TextBox).Text)

        ' Step three: Cycle through valid "data" cells and put 
        '             information back in underlying DataSet
        Dim intCount As Integer
        For intCount = 0 To e.Item.Cells.Count - 1
            If e.Item.Cells(intCount).Controls.Count > 0 Then
                If TypeOf (e.Item.Cells(intCount).Controls(0)) Is TextBox Then
                    ' This appears to be a TextBox-holding "data" cell
                    Dim strValue As String = CType(e.Item.Cells(intCount). _
                        Controls(0), TextBox).Text
                    ' Put value (or null if empty) back into relevant DataSet field
                    If strValue = "" Then
                        objEditedRow.Item(MyDataGrid.Columns(intCount). _
                            SortExpression) = System.DBNull.Value
                    Else
                        objEditedRow.Item(MyDataGrid.Columns(intCount). _
                            SortExpression) = strValue
                    End If
                End If
            End If
        Next

        ' Update backend data
        ParentDataAdapter.Update(MyDataSet)

        ' Deselect DataGrid items and rebind
        With MyDataGrid
            .SelectedIndex = -1
            .EditItemIndex = -1
            .DataSource = MyDataSet
            .DataBind()
        End With

    End Sub

    Private Sub MyDataGrid_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles MyDataGrid.CancelCommand
        ' This code runs when the Cancel button is clicked
        ' It simply resets and rebinds
        MyDataGrid.SelectedIndex = -1
        MyDataGrid.EditItemIndex = -1
        ParentDataAdapter.Fill(MyDataSet)
        ChildDataAdapter.Fill(MyDataSet)
        MyDataGrid.DataBind()
    End Sub

End Class
