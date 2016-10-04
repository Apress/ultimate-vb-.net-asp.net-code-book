Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents ListBox1 As System.Web.UI.WebControls.ListBox

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

    Public Enum Test
        ABC = 1
        DEF = 2
        GHI = 3
    End Enum

    Public Sub AddEnumToList(ByVal GetSystemType As System.Type, _
       ByVal List As System.Web.UI.WebControls.ListControl)
        ' Populates the specified list with the
        ' names and values of the passed system type
        Dim strNames As String(), arrValues As System.Array
        Dim intCount As Integer
        strNames = [Enum].GetNames(GetSystemType)
        arrValues = [Enum].GetValues(GetSystemType)
        List.Items.Clear()
        For intCount = LBound(strNames) To UBound(strNames)
            List.Items.Add(New _
               System.Web.UI.WebControls.ListItem(strNames(intCount), _
               arrValues.GetValue(intCount)))
        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddEnumToList(GetType(Test), ListBox1)
    End Sub
End Class
