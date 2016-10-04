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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents lnkAmazon As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lnkAmazon = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Go"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter an ISBN:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ISBN Lookup"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "159059021X"
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(48, 96)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(352, 40)
        Me.txtResults.TabIndex = 8
        Me.txtResults.Text = ""
        '
        'lnkAmazon
        '
        Me.lnkAmazon.Location = New System.Drawing.Point(48, 144)
        Me.lnkAmazon.Name = "lnkAmazon"
        Me.lnkAmazon.Size = New System.Drawing.Size(272, 23)
        Me.lnkAmazon.TabIndex = 9
        Me.lnkAmazon.TabStop = True
        Me.lnkAmazon.Text = "Click here for more information"
        Me.lnkAmazon.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 24)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Go"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(48, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Enter a term:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Book Search"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 216)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "Angela Lansbury"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(56, 264)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(344, 69)
        Me.ListBox1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 358)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListBox1, Me.Button2, Me.Label3, Me.Label4, Me.TextBox2, Me.lnkAmazon, Me.txtResults, Me.Button1, Me.Label2, Me.Label1, Me.TextBox1})
        Me.Name = "Form1"
        Me.Text = "Querying the Amazon.com Web Service"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create new search service object
        Dim objSearch As New _
                    com.amazon.soap.AmazonSearchService()
        ' Define properties for a new ASIN request
        Dim objASIN As New com.amazon.soap.AsinRequest()
        With objASIN
            .asin = TextBox1.Text
            .devtag = "XXXXXX"
            .type = "lite"
            .tag = "your-assoc-id"
        End With
        ' Perform ASIN search request and 
        ' return ProductInfo object
        Dim objProductInfo As New com.amazon.soap.ProductInfo()
        objProductInfo = objSearch.AsinSearchRequest(objASIN)
        ' Retrieve various details
        txtResults.Text = objProductInfo.Details(0).ProductName & _
            ", Price: " & objProductInfo.Details(0).OurPrice
        txtResults.Text += vbNewLine & "Author(s): " & _
            Join(objProductInfo.Details(0).Authors, ", ")
        lnkAmazon.Visible = True
        lnkAmazon.Tag = objProductInfo.Details(0).Url
    End Sub

    Private Sub lnkAmazon_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAmazon.LinkClicked
        System.Diagnostics.Process.Start(lnkAmazon.Tag)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Create new search service object
        Dim objSearch As New _
                    com.amazon.soap.AmazonSearchService()
        ' Define properties for a new keyword request
        Dim objKeyword As New com.amazon.soap.KeywordRequest()
        With objKeyword
            .keyword = TextBox2.Text
            .devtag = "XXXXXX"
            .mode = "books"
            .type = "heavy"
            .tag = "your-assoc-id"
            .page = "1"
        End With
        ' Perform keyword search request and 
        ' return ProductInfo object
        Dim objProductInfo As New com.amazon.soap.ProductInfo()
        objProductInfo = objSearch.KeywordSearchRequest(objKeyword)
        ' Cycle through results
        Dim shtCount As Short
        ListBox1.Items.Clear()
        For shtCount = 0 To objProductInfo.Details.Length - 1
            ListBox1.Items.Add(objProductInfo.Details(shtCount).OurPrice & " > " & objProductInfo.Details(shtCount).ProductName)
        Next
    End Sub
End Class
