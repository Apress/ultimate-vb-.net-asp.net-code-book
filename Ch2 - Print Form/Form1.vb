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
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents MyPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents MyPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.MyPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.MyPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyPrintDocument
        '
        '
        'MyPictureBox
        '
        Me.MyPictureBox.Location = New System.Drawing.Point(296, 16)
        Me.MyPictureBox.Name = "MyPictureBox"
        Me.MyPictureBox.Size = New System.Drawing.Size(16, 16)
        Me.MyPictureBox.TabIndex = 0
        Me.MyPictureBox.TabStop = False
        Me.MyPictureBox.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales Summary for May, 2004"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.DataGrid1.BackColor = System.Drawing.Color.GhostWhite
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.White
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.Lavender
        Me.DataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid1.Location = New System.Drawing.Point(16, 48)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.Teal
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.DataGrid1.Size = New System.Drawing.Size(392, 368)
        Me.DataGrid1.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(432, 256)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2003, 3, 31, 0, 0, 0, 0), New Date(2003, 4, 6, 0, 0, 0, 0))
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 3
        Me.MonthCalendar1.TodayDate = New Date(2004, 5, 31, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Best sales week for 2004:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Best sales week for May, 2004:"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(432, 48)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2004, 5, 17, 0, 0, 0, 0), New Date(2004, 5, 23, 0, 0, 0, 0))
        Me.MonthCalendar2.TabIndex = 5
        Me.MonthCalendar2.TodayDate = New Date(2004, 5, 31, 0, 0, 0, 0)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(368, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 16)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Print"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 430)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabel1, Me.Label3, Me.MonthCalendar2, Me.Label2, Me.MonthCalendar1, Me.DataGrid1, Me.Label1, Me.MyPictureBox})
        Me.Name = "Form1"
        Me.Text = "The Secret Rebirth of .PrintForm"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub PrintForm()
        ' Takes a screenshot, then initiates the print
        GrabScreen()
        MyPrintDialog.Document = MyPrintDocument
        If MyPrintDialog.ShowDialog = DialogResult.OK Then
            MyPrintDocument.Print()
        End If
    End Sub

    ' API call to help generate final screenshot
    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal _
        nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight _
        As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, _
        ByVal nYSrc As Integer, ByVal dwRop As System.Int32) As Boolean
    ' Variable to store screenshot
    Private bmpScreenshot As Bitmap

    Private Sub GrabScreen()
        ' Performs a screenshot, saving results to bmpScreenshot
        Dim objGraphics As Graphics = Me.CreateGraphics
        Dim objSize As Size = Me.Size
        Const SRCCOPY As Integer = &HCC0020

        bmpScreenshot = New Bitmap(objSize.Width, objSize.Height, objGraphics)
        Dim objGraphics2 As Graphics = objGraphics.FromImage(bmpScreenshot)
        Dim deviceContext1 As IntPtr = objGraphics.GetHdc
        Dim deviceContext2 As IntPtr = objGraphics2.GetHdc

        BitBlt(deviceContext2, 0, 0, Me.ClientRectangle.Width, _
            Me.ClientRectangle.Height, deviceContext1, 0, 0, SRCCOPY)
        objGraphics.ReleaseHdc(deviceContext1)
        objGraphics2.ReleaseHdc(deviceContext2)
    End Sub

    Private Sub MyPrintDocument_PrintPage(ByVal sender As System.Object, _
        ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
        Handles MyPrintDocument.PrintPage
        ' Method that handles the printing
        Dim objImageToPrint As Graphics = e.Graphics
        objImageToPrint.DrawImage(bmpScreenshot, 0, 0)
        bmpScreenshot.Dispose()
        objImageToPrint.Dispose()
        e.HasMorePages = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.Visible = False
        PrintForm()
        LinkLabel1.Visible = True
    End Sub

End Class
