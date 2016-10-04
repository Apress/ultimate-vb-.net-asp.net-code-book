Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents ListBox1 As System.Web.UI.WebControls.ListBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Public Sub MoveSelectedItemUp(ByVal List As _
      System.Web.UI.WebControls.ListControl)
        ' Move the selected item in the passed ListBox
        ' up one, if possible. Sample usage:
        ' - MoveSelectedItemUp(ListBox1)
        If Not List.SelectedItem Is Nothing Then
            Dim objListItem As System.Web.UI.WebControls.ListItem, _
              intPosition As Integer
            objListItem = List.SelectedItem
            intPosition = List.Items.IndexOf(objListItem)
            List.Items.Remove(objListItem)
            List.Items.Insert(IIf(intPosition = 0, 0, intPosition - 1), objListItem)
        End If
    End Sub

    Public Sub MoveSelectedItemDown(ByVal List As _
      System.Web.UI.WebControls.ListControl)
        ' Move the selected item in the passed ListBox
        ' down one, if possible
        If Not List.SelectedItem Is Nothing Then
            Dim objListItem As System.Web.UI.WebControls.ListItem, _
              intPosition As Integer
            objListItem = List.SelectedItem
            intPosition = List.Items.IndexOf(objListItem)
            If intPosition = List.Items.Count - 1 Then Exit Sub
            List.Items.Remove(objListItem)
            List.Items.Insert(intPosition + 1, objListItem)
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MoveSelectedItemUp(ListBox1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MoveSelectedItemDown(ListBox1)
    End Sub
End Class
