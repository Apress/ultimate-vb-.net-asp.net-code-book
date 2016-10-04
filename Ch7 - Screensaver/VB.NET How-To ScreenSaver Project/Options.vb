Option Strict On

Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO

' This is the class that holds the Options information.  The Options information
'   is defined as a class so that it can be easily serialized and deserialized.
<Serializable()> Public Class Options

    ' Set up the class variables and make them their defaults
    Private m_Speed As String = "Fast"
    Private m_Shape As String = "Ellipse"
    Private m_IsTransparent As Boolean = True
    ' Set the OptionsPath to the current location with a fixed file name.
    Private OptionsPath As String = Environment.CurrentDirectory & "\VB.NET How-To Screen Saver Options.opt"

    ' --- Class Properties ---

    ' This property returns whether the screen saver should use transparency
    '   when drawing the shapes to the screen.
    Public Property IsTransparent() As Boolean
        Get
            Return m_IsTransparent
        End Get
        Set(ByVal Value As Boolean)
            m_IsTransparent = Value
        End Set
    End Property

    ' This property returns what shapes the screen saver should use 
    '   when drawing to the screen.
    Public Property Shape() As String
        Get
            Return m_Shape
        End Get
        Set(ByVal Value As String)
            m_Shape = Value
        End Set
    End Property

    ' This property returns what speed the screen saver should use 
    '   when drawing to the screen.
    Public Property Speed() As String
        Get
            Return m_Speed
        End Get
        Set(ByVal Value As String)
            m_Speed = Value
        End Set
    End Property

    ' --- Class Methods ---

    ' This function returns 'true' if the options file exists, 'false' otherwise.
    Public Function IsOptionFileExisting() As Boolean
        Dim myIO As New System.IO.FileInfo(OptionsPath)
        Return myIO.Exists()
    End Function

    ' This function loads the user defined options.  First, it checks to see
    '   if an options file exists. If it does, the options are loaded from it.
    '   If the file doesn't exist, one is created with the defaults.
    Public Sub LoadOptions()

        Dim myOptions As New Options() ' An Options object to use

        ' Check to see if an Option file exists, if so, load it!  Else
        '   create one.
        If myOptions.IsOptionFileExisting() Then

            ' Load the options
            ' Create an XmlSerializer to use for retrieving options values
            Dim mySerializer As New XmlSerializer(GetType(Options))
            ' Create a StreamReader to point to the options file
            Dim myTextReader As New StreamReader(OptionsPath)
            ' Create an XmlTextReader to actually read the options.
            Dim myXmlReader As New Xml.XmlTextReader(myTextReader)

            ' First verify that the file can be deserialized into an Option
            '   object format.
            If mySerializer.CanDeserialize(myXmlReader) Then
                ' Deserialize the object
                myOptions = CType(mySerializer.Deserialize(myXmlReader), Options)
            Else
                ' Save a new Options file
                myOptions.SaveOptions()
            End If

            ' Close the IO objects we've used.
            myXmlReader.Close()
            myTextReader.Close()

            ' Set the properties for this Options object to those retrieved
            '   from the file (or else use the defaults from the temporary
            '   Options object, if the file could not be deserialized).
            Me.Speed = myOptions.Speed
            Me.IsTransparent = myOptions.IsTransparent
            Me.Shape = myOptions.Shape

        End If
    End Sub

    ' This function saves the user defined options to disk.
    Public Sub SaveOptions()

        ' Create a stream writer to overwrite any files currently there, so that
        '   the fresh options can be saved.
        Dim myWriter As New System.IO.StreamWriter(OptionsPath)

        ' Create an XML Serializer to serialize the object
        Dim myXmlSerializer As New XmlSerializer(Me.GetType())

        ' Serialize the current Options object (Me) to disk.
        myXmlSerializer.Serialize(myWriter, Me)

        ' Close the writer.
        myWriter.Close()

    End Sub

End Class
