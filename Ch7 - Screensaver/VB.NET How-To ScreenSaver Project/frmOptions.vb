Option Strict On

Imports System.IO

Public Class frmOptions
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
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkTransparent As System.Windows.Forms.CheckBox
    Friend WithEvents optRectangles As System.Windows.Forms.RadioButton
    Friend WithEvents optEllipses As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSpeed As System.Windows.Forms.ComboBox
    Friend WithEvents grpShapes As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOptions))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkTransparent = New System.Windows.Forms.CheckBox()
        Me.grpShapes = New System.Windows.Forms.GroupBox()
        Me.optEllipses = New System.Windows.Forms.RadioButton()
        Me.optRectangles = New System.Windows.Forms.RadioButton()
        Me.cboSpeed = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpShapes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.AccessibleDescription = resources.GetString("btnOK.AccessibleDescription")
        Me.btnOK.AccessibleName = resources.GetString("btnOK.AccessibleName")
        Me.btnOK.Anchor = CType(resources.GetObject("btnOK.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Dock = CType(resources.GetObject("btnOK.Dock"), System.Windows.Forms.DockStyle)
        Me.btnOK.Enabled = CType(resources.GetObject("btnOK.Enabled"), Boolean)
        Me.btnOK.FlatStyle = CType(resources.GetObject("btnOK.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnOK.Font = CType(resources.GetObject("btnOK.Font"), System.Drawing.Font)
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = CType(resources.GetObject("btnOK.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnOK.ImageIndex = CType(resources.GetObject("btnOK.ImageIndex"), Integer)
        Me.btnOK.ImeMode = CType(resources.GetObject("btnOK.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnOK.Location = CType(resources.GetObject("btnOK.Location"), System.Drawing.Point)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = CType(resources.GetObject("btnOK.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnOK.Size = CType(resources.GetObject("btnOK.Size"), System.Drawing.Size)
        Me.btnOK.TabIndex = CType(resources.GetObject("btnOK.TabIndex"), Integer)
        Me.btnOK.Text = resources.GetString("btnOK.Text")
        Me.btnOK.TextAlign = CType(resources.GetObject("btnOK.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnOK.Visible = CType(resources.GetObject("btnOK.Visible"), Boolean)
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = resources.GetString("btnCancel.AccessibleDescription")
        Me.btnCancel.AccessibleName = resources.GetString("btnCancel.AccessibleName")
        Me.btnCancel.Anchor = CType(resources.GetObject("btnCancel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Dock = CType(resources.GetObject("btnCancel.Dock"), System.Windows.Forms.DockStyle)
        Me.btnCancel.Enabled = CType(resources.GetObject("btnCancel.Enabled"), Boolean)
        Me.btnCancel.FlatStyle = CType(resources.GetObject("btnCancel.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnCancel.Font = CType(resources.GetObject("btnCancel.Font"), System.Drawing.Font)
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = CType(resources.GetObject("btnCancel.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnCancel.ImageIndex = CType(resources.GetObject("btnCancel.ImageIndex"), Integer)
        Me.btnCancel.ImeMode = CType(resources.GetObject("btnCancel.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnCancel.Location = CType(resources.GetObject("btnCancel.Location"), System.Drawing.Point)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = CType(resources.GetObject("btnCancel.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnCancel.Size = CType(resources.GetObject("btnCancel.Size"), System.Drawing.Size)
        Me.btnCancel.TabIndex = CType(resources.GetObject("btnCancel.TabIndex"), Integer)
        Me.btnCancel.Text = resources.GetString("btnCancel.Text")
        Me.btnCancel.TextAlign = CType(resources.GetObject("btnCancel.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnCancel.Visible = CType(resources.GetObject("btnCancel.Visible"), Boolean)
        '
        'chkTransparent
        '
        Me.chkTransparent.AccessibleDescription = resources.GetString("chkTransparent.AccessibleDescription")
        Me.chkTransparent.AccessibleName = resources.GetString("chkTransparent.AccessibleName")
        Me.chkTransparent.Anchor = CType(resources.GetObject("chkTransparent.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.chkTransparent.Appearance = CType(resources.GetObject("chkTransparent.Appearance"), System.Windows.Forms.Appearance)
        Me.chkTransparent.BackgroundImage = CType(resources.GetObject("chkTransparent.BackgroundImage"), System.Drawing.Image)
        Me.chkTransparent.CheckAlign = CType(resources.GetObject("chkTransparent.CheckAlign"), System.Drawing.ContentAlignment)
        Me.chkTransparent.Dock = CType(resources.GetObject("chkTransparent.Dock"), System.Windows.Forms.DockStyle)
        Me.chkTransparent.Enabled = CType(resources.GetObject("chkTransparent.Enabled"), Boolean)
        Me.chkTransparent.FlatStyle = CType(resources.GetObject("chkTransparent.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.chkTransparent.Font = CType(resources.GetObject("chkTransparent.Font"), System.Drawing.Font)
        Me.chkTransparent.Image = CType(resources.GetObject("chkTransparent.Image"), System.Drawing.Image)
        Me.chkTransparent.ImageAlign = CType(resources.GetObject("chkTransparent.ImageAlign"), System.Drawing.ContentAlignment)
        Me.chkTransparent.ImageIndex = CType(resources.GetObject("chkTransparent.ImageIndex"), Integer)
        Me.chkTransparent.ImeMode = CType(resources.GetObject("chkTransparent.ImeMode"), System.Windows.Forms.ImeMode)
        Me.chkTransparent.Location = CType(resources.GetObject("chkTransparent.Location"), System.Drawing.Point)
        Me.chkTransparent.Name = "chkTransparent"
        Me.chkTransparent.RightToLeft = CType(resources.GetObject("chkTransparent.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.chkTransparent.Size = CType(resources.GetObject("chkTransparent.Size"), System.Drawing.Size)
        Me.chkTransparent.TabIndex = CType(resources.GetObject("chkTransparent.TabIndex"), Integer)
        Me.chkTransparent.Text = resources.GetString("chkTransparent.Text")
        Me.chkTransparent.TextAlign = CType(resources.GetObject("chkTransparent.TextAlign"), System.Drawing.ContentAlignment)
        Me.chkTransparent.Visible = CType(resources.GetObject("chkTransparent.Visible"), Boolean)
        '
        'grpShapes
        '
        Me.grpShapes.AccessibleDescription = resources.GetString("grpShapes.AccessibleDescription")
        Me.grpShapes.AccessibleName = resources.GetString("grpShapes.AccessibleName")
        Me.grpShapes.Anchor = CType(resources.GetObject("grpShapes.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grpShapes.BackgroundImage = CType(resources.GetObject("grpShapes.BackgroundImage"), System.Drawing.Image)
        Me.grpShapes.Controls.AddRange(New System.Windows.Forms.Control() {Me.optEllipses, Me.optRectangles})
        Me.grpShapes.Dock = CType(resources.GetObject("grpShapes.Dock"), System.Windows.Forms.DockStyle)
        Me.grpShapes.Enabled = CType(resources.GetObject("grpShapes.Enabled"), Boolean)
        Me.grpShapes.Font = CType(resources.GetObject("grpShapes.Font"), System.Drawing.Font)
        Me.grpShapes.ImeMode = CType(resources.GetObject("grpShapes.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grpShapes.Location = CType(resources.GetObject("grpShapes.Location"), System.Drawing.Point)
        Me.grpShapes.Name = "grpShapes"
        Me.grpShapes.RightToLeft = CType(resources.GetObject("grpShapes.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.grpShapes.Size = CType(resources.GetObject("grpShapes.Size"), System.Drawing.Size)
        Me.grpShapes.TabIndex = CType(resources.GetObject("grpShapes.TabIndex"), Integer)
        Me.grpShapes.TabStop = False
        Me.grpShapes.Text = resources.GetString("grpShapes.Text")
        Me.grpShapes.Visible = CType(resources.GetObject("grpShapes.Visible"), Boolean)
        '
        'optEllipses
        '
        Me.optEllipses.AccessibleDescription = resources.GetString("optEllipses.AccessibleDescription")
        Me.optEllipses.AccessibleName = resources.GetString("optEllipses.AccessibleName")
        Me.optEllipses.Anchor = CType(resources.GetObject("optEllipses.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.optEllipses.Appearance = CType(resources.GetObject("optEllipses.Appearance"), System.Windows.Forms.Appearance)
        Me.optEllipses.BackgroundImage = CType(resources.GetObject("optEllipses.BackgroundImage"), System.Drawing.Image)
        Me.optEllipses.CheckAlign = CType(resources.GetObject("optEllipses.CheckAlign"), System.Drawing.ContentAlignment)
        Me.optEllipses.Dock = CType(resources.GetObject("optEllipses.Dock"), System.Windows.Forms.DockStyle)
        Me.optEllipses.Enabled = CType(resources.GetObject("optEllipses.Enabled"), Boolean)
        Me.optEllipses.FlatStyle = CType(resources.GetObject("optEllipses.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.optEllipses.Font = CType(resources.GetObject("optEllipses.Font"), System.Drawing.Font)
        Me.optEllipses.Image = CType(resources.GetObject("optEllipses.Image"), System.Drawing.Image)
        Me.optEllipses.ImageAlign = CType(resources.GetObject("optEllipses.ImageAlign"), System.Drawing.ContentAlignment)
        Me.optEllipses.ImageIndex = CType(resources.GetObject("optEllipses.ImageIndex"), Integer)
        Me.optEllipses.ImeMode = CType(resources.GetObject("optEllipses.ImeMode"), System.Windows.Forms.ImeMode)
        Me.optEllipses.Location = CType(resources.GetObject("optEllipses.Location"), System.Drawing.Point)
        Me.optEllipses.Name = "optEllipses"
        Me.optEllipses.RightToLeft = CType(resources.GetObject("optEllipses.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.optEllipses.Size = CType(resources.GetObject("optEllipses.Size"), System.Drawing.Size)
        Me.optEllipses.TabIndex = CType(resources.GetObject("optEllipses.TabIndex"), Integer)
        Me.optEllipses.Text = resources.GetString("optEllipses.Text")
        Me.optEllipses.TextAlign = CType(resources.GetObject("optEllipses.TextAlign"), System.Drawing.ContentAlignment)
        Me.optEllipses.Visible = CType(resources.GetObject("optEllipses.Visible"), Boolean)
        '
        'optRectangles
        '
        Me.optRectangles.AccessibleDescription = resources.GetString("optRectangles.AccessibleDescription")
        Me.optRectangles.AccessibleName = resources.GetString("optRectangles.AccessibleName")
        Me.optRectangles.Anchor = CType(resources.GetObject("optRectangles.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.optRectangles.Appearance = CType(resources.GetObject("optRectangles.Appearance"), System.Windows.Forms.Appearance)
        Me.optRectangles.BackgroundImage = CType(resources.GetObject("optRectangles.BackgroundImage"), System.Drawing.Image)
        Me.optRectangles.CheckAlign = CType(resources.GetObject("optRectangles.CheckAlign"), System.Drawing.ContentAlignment)
        Me.optRectangles.Dock = CType(resources.GetObject("optRectangles.Dock"), System.Windows.Forms.DockStyle)
        Me.optRectangles.Enabled = CType(resources.GetObject("optRectangles.Enabled"), Boolean)
        Me.optRectangles.FlatStyle = CType(resources.GetObject("optRectangles.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.optRectangles.Font = CType(resources.GetObject("optRectangles.Font"), System.Drawing.Font)
        Me.optRectangles.Image = CType(resources.GetObject("optRectangles.Image"), System.Drawing.Image)
        Me.optRectangles.ImageAlign = CType(resources.GetObject("optRectangles.ImageAlign"), System.Drawing.ContentAlignment)
        Me.optRectangles.ImageIndex = CType(resources.GetObject("optRectangles.ImageIndex"), Integer)
        Me.optRectangles.ImeMode = CType(resources.GetObject("optRectangles.ImeMode"), System.Windows.Forms.ImeMode)
        Me.optRectangles.Location = CType(resources.GetObject("optRectangles.Location"), System.Drawing.Point)
        Me.optRectangles.Name = "optRectangles"
        Me.optRectangles.RightToLeft = CType(resources.GetObject("optRectangles.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.optRectangles.Size = CType(resources.GetObject("optRectangles.Size"), System.Drawing.Size)
        Me.optRectangles.TabIndex = CType(resources.GetObject("optRectangles.TabIndex"), Integer)
        Me.optRectangles.Text = resources.GetString("optRectangles.Text")
        Me.optRectangles.TextAlign = CType(resources.GetObject("optRectangles.TextAlign"), System.Drawing.ContentAlignment)
        Me.optRectangles.Visible = CType(resources.GetObject("optRectangles.Visible"), Boolean)
        '
        'cboSpeed
        '
        Me.cboSpeed.AccessibleDescription = resources.GetString("cboSpeed.AccessibleDescription")
        Me.cboSpeed.AccessibleName = resources.GetString("cboSpeed.AccessibleName")
        Me.cboSpeed.Anchor = CType(resources.GetObject("cboSpeed.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cboSpeed.BackgroundImage = CType(resources.GetObject("cboSpeed.BackgroundImage"), System.Drawing.Image)
        Me.cboSpeed.Dock = CType(resources.GetObject("cboSpeed.Dock"), System.Windows.Forms.DockStyle)
        Me.cboSpeed.Enabled = CType(resources.GetObject("cboSpeed.Enabled"), Boolean)
        Me.cboSpeed.Font = CType(resources.GetObject("cboSpeed.Font"), System.Drawing.Font)
        Me.cboSpeed.ImeMode = CType(resources.GetObject("cboSpeed.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cboSpeed.IntegralHeight = CType(resources.GetObject("cboSpeed.IntegralHeight"), Boolean)
        Me.cboSpeed.ItemHeight = CType(resources.GetObject("cboSpeed.ItemHeight"), Integer)
        Me.cboSpeed.Items.AddRange(New Object() {resources.GetString("cboSpeed.Items.Items"), resources.GetString("cboSpeed.Items.Items1"), resources.GetString("cboSpeed.Items.Items2")})
        Me.cboSpeed.Location = CType(resources.GetObject("cboSpeed.Location"), System.Drawing.Point)
        Me.cboSpeed.MaxDropDownItems = CType(resources.GetObject("cboSpeed.MaxDropDownItems"), Integer)
        Me.cboSpeed.MaxLength = CType(resources.GetObject("cboSpeed.MaxLength"), Integer)
        Me.cboSpeed.Name = "cboSpeed"
        Me.cboSpeed.RightToLeft = CType(resources.GetObject("cboSpeed.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cboSpeed.Size = CType(resources.GetObject("cboSpeed.Size"), System.Drawing.Size)
        Me.cboSpeed.TabIndex = CType(resources.GetObject("cboSpeed.TabIndex"), Integer)
        Me.cboSpeed.Text = resources.GetString("cboSpeed.Text")
        Me.cboSpeed.Visible = CType(resources.GetObject("cboSpeed.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'frmOptions
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
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.cboSpeed, Me.grpShapes, Me.chkTransparent, Me.btnCancel, Me.btnOK})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmOptions"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.grpShapes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This code just closes the form, when the user decides to Cancel.
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' This code changes the values in the Options object to the new user
    '   selected values, and saves it to disk.
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim myOptions As New Options()

        If Me.optEllipses.Checked Then
            myOptions.Shape = "Ellipses"
        Else
            myOptions.Shape = "Rectangles"
        End If

        myOptions.IsTransparent = Me.chkTransparent.Checked
        myOptions.Speed = Me.cboSpeed.Text

        ' Save the options to disk.
        myOptions.SaveOptions()

        ' Close this object.
        Me.Close()

    End Sub

    ' This code loads the current user defined options and sets the UI elements
    '   in this form to their proper values.
    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load the options file.  Recall that the load method will
        '   always return an options object, even if the file doesn't
        '   currently exist
        Dim myOptions As New Options()
        myOptions.LoadOptions()

        Me.cboSpeed.Text = myOptions.Speed
        Me.chkTransparent.Checked = myOptions.IsTransparent

        If myOptions.Shape = "Ellipses" Then
            Me.optEllipses.Checked = True
        Else
            Me.optRectangles.Checked = True
        End If

    End Sub

End Class
