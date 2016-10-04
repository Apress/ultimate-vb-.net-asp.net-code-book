Public Class TextPrint
    ' Inherits all the functionality of a PrintDocument
    Inherits Printing.PrintDocument
    ' Private variables to hold default font and text
    Private fntPrintFont As Font
    Private strText As String
    Public Sub New(ByVal Text As String)
        ' Sets the file stream
        MyBase.New()
        strText = Text
    End Sub
    Public Property Text() As String
        Get
            Return strText
        End Get
        Set(ByVal Value As String)
            strText = Value
        End Set
    End Property
    Protected Overrides Sub OnBeginPrint(ByVal ev As Printing.PrintEventArgs)
        ' Run base code
        MyBase.OnBeginPrint(ev)
        ' Sets the default font
        If fntPrintFont Is Nothing Then
            fntPrintFont = New Font("Times New Roman", 12)
        End If
    End Sub
    Public Property Font() As Font
        ' Allows the user to override the default font
        Get
            Return fntPrintFont
        End Get
        Set(ByVal Value As Font)
            fntPrintFont = Value
        End Set
    End Property
    Protected Overrides Sub OnPrintPage(ByVal ev _
       As Printing.PrintPageEventArgs)
        ' Provides the print logic for our document

        ' Run base code
        MyBase.OnPrintPage(ev)
        ' Variables
        Static intCurrentChar As Integer
        Dim intPrintAreaHeight, intPrintAreaWidth, _
            intMarginLeft, intMarginTop As Integer
        ' Set printing area boundaries and margin coordinates
        With MyBase.DefaultPageSettings
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
            intMarginLeft = .Margins.Left 'X
            intMarginTop = .Margins.Top   'Y
        End With
        ' If Landscape set, swap printing height/width
        If MyBase.DefaultPageSettings.Landscape Then
            Dim intTemp As Integer
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If
        ' Calculate total number of lines
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / Font.Height)
        ' Initialise rectangle printing area
        Dim rectPrintingArea As New RectangleF(intMarginLeft, intMarginTop, _
            intPrintAreaWidth, intPrintAreaHeight)
        ' Initialise StringFormat class, for text layout
        Dim objSF As New StringFormat(StringFormatFlags.LineLimit)
        ' Figure out how many lines will fit into rectangle
        Dim intLinesFilled, intCharsFitted As Int32
        ev.Graphics.MeasureString(Mid(strText, _
                    UpgradeZeros(intCurrentChar)), Font, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, _
                    intCharsFitted, intLinesFilled)
        ' Print the text to the page
        ev.Graphics.DrawString(Mid(strText, _
            UpgradeZeros(intCurrentChar)), Font, _
            Brushes.Black, rectPrintingArea, objSF)
        ' Increase current char count
        intCurrentChar += intCharsFitted
        ' Check whether we need to print more
        If intCurrentChar < strText.Length Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
            intCurrentChar = 0
        End If
    End Sub
    Public Function UpgradeZeros(ByVal Input As Integer) As Integer
        ' Upgrades all zeros to ones
        ' - used as opposed to defunct IIF or messy If statements
        If Input = 0 Then
            Return 1
        Else
            Return Input
        End If
    End Function
End Class
