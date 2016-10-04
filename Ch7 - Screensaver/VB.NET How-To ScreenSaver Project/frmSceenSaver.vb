Option Strict On

' This form is the main form for the screen saver. It does all the painting
'   of the screen, and handles when it should terminate and release control 
'   back to Windows.
Public Class frmSceenSaver
    Inherits System.Windows.Forms.Form

    ' Declare the class variables that will be used for the Screen
    '   Saver.
    Private m_Graphics As Graphics ' Graphics object on which to draw
    Private m_Random As New Random() ' Random object to support the drawing
    ' Options object that contains information about the user selected options
    Private m_Options As New Options()
    ' Used to for first setting MouseMove location
    Private m_IsActive As Boolean = False
    ' Used to determine if the Mouse has actually been moved
    Private m_MouseLocation As Point



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
    Friend WithEvents tmrUpdateScreen As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSceenSaver))
        Me.tmrUpdateScreen = New System.Windows.Forms.Timer(Me.components)
        '
        'tmrUpdateScreen
        '
        '
        'frmSceenSaver
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.ControlBox = False
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmSceenSaver"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TopMost = True
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    ' Close the screen saver when the user moves the mouse. Unfortunately, the 
    '   MouseMove event is fired by some very trivial moves of the mouse, so 
    '   instead, verify that the mouse has actually been moved by at least
    '   a few pixels before exiting.
    Private Sub frmSceenSaver_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        ' If the MouseLocation still points to 0,0, move it to its actual location
        '   and save the location for later. Otherwise, check to see if the user
        '   has moved the mouse at least 10 pixels.
        If Not m_IsActive Then
            Me.m_MouseLocation = New Point(e.X, e.Y)
            m_IsActive = True
        Else
            If Math.Abs(e.X - Me.m_MouseLocation.X) > 10 Or _
                Math.Abs(e.Y - Me.m_MouseLocation.Y) > 10 Then
                ' The user has moved the mouse so leave this program
                Application.Exit()
            End If
        End If
    End Sub

    ' This subroutine initializes the Screen Saver form when it is loaded
    Private Sub frmSceenSaver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Create the Graphics object to use when drawing.
        Me.m_Graphics = Me.CreateGraphics()

        ' Load the Saved options. Remember that if no Options file exists, one
        '   will be created.
        m_Options.LoadOptions()

        ' Set the speed based on the user defined Options.
        Select Case m_Options.Speed
            Case "Slow"
                Me.tmrUpdateScreen.Interval = 500
            Case "Fast"
                Me.tmrUpdateScreen.Interval = 100
            Case Else
                Me.tmrUpdateScreen.Interval = 200
        End Select

        ' Enable the timer.
        Me.tmrUpdateScreen.Enabled = True

    End Sub

    ' The subroutine causes the screen saver to close if the user 
    '   pushes a mouse button.
    Private Sub frmSceenSaver_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        Application.Exit()
    End Sub

    ' This code is executed whenever the timer tick event if fired. It draws
    '   a shape to the screen.
    Private Sub tmrUpdateScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdateScreen.Tick
        DrawShape()
    End Sub

    ' --- Class Methods ---

    ' This subroutine just draws a randomly colored, randomly sized, shapes to 
    '   the screen, based on some user defined parameters.
    Private Sub DrawShape()

        ' Get the largest possible values for the screen
        Dim maxX As Integer = Me.Width
        Dim maxY As Integer = Me.Height

        Dim x1, x2, y1, y2 As Integer ' Coordinates of random points
        Dim myRect As Rectangle ' Rectangle to paint the shapes
        Dim myColor As Color ' Color used to paint the shapes

        ' Generate some random numbers to use as coordinates
        x1 = m_Random.Next(0, maxX)
        x2 = m_Random.Next(0, maxX)

        y1 = m_Random.Next(0, maxY)
        y2 = m_Random.Next(0, maxY)

        ' Create a rectangle based on the randomly generated coordinates
        myRect = New Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), _
                Math.Abs(x1 - x2), Math.Abs(y1 - y2))


        ' Get a random color. If the user wants transparency then allow the
        '   transparency to be randomly generated as well.  If not, then set the
        '   Alpha to 255 (the max).
        If m_Options.IsTransparent Then
            myColor = Color.FromArgb(m_Random.Next(255), m_Random.Next(255), _
                m_Random.Next(255), m_Random.Next(255))
        Else
            myColor = Color.FromArgb(255, m_Random.Next(255), _
                m_Random.Next(255), m_Random.Next(255))
        End If

        ' Draw an Ellipse or rectangle based on User defined options.
        If m_Options.Shape = "Ellipses" Then
            m_Graphics.FillEllipse(New SolidBrush(myColor), myRect)
        Else
            m_Graphics.FillRectangle(New SolidBrush(myColor), myRect)
        End If
    End Sub

    ' This sub is the first one that executes when the Screen Saver 
    '   program is run.  Since Windows will pass parameters to the this
    '   program whenever a user is setting up the screen saver using the 
    '   Display Properties -> Screen Saver property screen.
    <STAThread()> Shared Sub Main(ByVal args As String())

        ' Check to see if there were any passed arguments. If not, then
        '   the user simply double-clicked on the .scr file.
        If args.Length > 0 Then
            ' This means we have some passed arguments.  Windows will
            '   automatically pass a "/s", "/p" or a "/c" depending
            '   on how the screen saver should behave.  The meanings for each
            '   of these parameters is seen below.

            ' Check to see if the Screen saver should preview.
            If args(0).ToLower = "/p" Then
                ' This functionality is not implemented here because it involves
                '   creating and joining threads and is beyond the scope of this
                '   How-To.

                ' Simply exit the application
                Application.Exit()
            End If

            ' Check to see if the Screen saver should show user definable options.
            If args(0).ToLower.Trim().Substring(0, 2) = "/c" Then
                ' Create a frmOptions form and display it.
                Dim userOptionsForm As New frmOptions()
                userOptionsForm.ShowDialog()

                ' Exit the application.
                Application.Exit()
            End If

            ' Check to see if the Screen saver should simply execute
            If args(0).ToLower = "/s" Then

                ' Create a frmSceenSaver form and display it.
                Dim screenSaverForm As New ScreenSaver.frmSceenSaver()
                screenSaverForm.ShowDialog()

                ' Exit the application when the form is closed
                Application.Exit()
            End If


        Else
            ' Fire up the Screen saver.  Note: This is only used when the user
            '   double clicks on the EXE, since otherwise windows passes a
            '   parameter to the application.

            ' Create a frmSceenSaver form and display it.
            Dim screenSaverForm As New ScreenSaver.frmSceenSaver()
            screenSaverForm.ShowDialog()

            ' Exit the application when the form is closed
            Application.Exit()
        End If
    End Sub

End Class
