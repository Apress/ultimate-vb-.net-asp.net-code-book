'Copyright (C) 2002 Microsoft Corporation
'All rights reserved.
'THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
'EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
'MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

'Requires the Trial or Release version of Visual Studio .NET Professional (or greater).

Option Strict On

Public Class frmAbout
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
	Friend WithEvents pbIcon As System.Windows.Forms.PictureBox
	Friend WithEvents lblTitle As System.Windows.Forms.Label
	Friend WithEvents lblVersion As System.Windows.Forms.Label
	Friend WithEvents lblDescription As System.Windows.Forms.Label
	Friend WithEvents cmdOK As System.Windows.Forms.Button
	Friend WithEvents lblCopyright As System.Windows.Forms.Label
	Friend WithEvents lblCodebase As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblCodebase = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbIcon
        '
        Me.pbIcon.AccessibleDescription = CType(resources.GetObject("pbIcon.AccessibleDescription"), String)
        Me.pbIcon.AccessibleName = CType(resources.GetObject("pbIcon.AccessibleName"), String)
        Me.pbIcon.Anchor = CType(resources.GetObject("pbIcon.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.pbIcon.BackgroundImage = CType(resources.GetObject("pbIcon.BackgroundImage"), System.Drawing.Image)
        Me.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbIcon.Dock = CType(resources.GetObject("pbIcon.Dock"), System.Windows.Forms.DockStyle)
        Me.pbIcon.Enabled = CType(resources.GetObject("pbIcon.Enabled"), Boolean)
        Me.pbIcon.Font = CType(resources.GetObject("pbIcon.Font"), System.Drawing.Font)
        Me.pbIcon.Image = CType(resources.GetObject("pbIcon.Image"), System.Drawing.Image)
        Me.pbIcon.ImeMode = CType(resources.GetObject("pbIcon.ImeMode"), System.Windows.Forms.ImeMode)
        Me.pbIcon.Location = CType(resources.GetObject("pbIcon.Location"), System.Drawing.Point)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.RightToLeft = CType(resources.GetObject("pbIcon.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.pbIcon.Size = CType(resources.GetObject("pbIcon.Size"), System.Drawing.Size)
        Me.pbIcon.SizeMode = CType(resources.GetObject("pbIcon.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.pbIcon.TabIndex = CType(resources.GetObject("pbIcon.TabIndex"), Integer)
        Me.pbIcon.TabStop = False
        Me.pbIcon.Text = resources.GetString("pbIcon.Text")
        Me.pbIcon.Visible = CType(resources.GetObject("pbIcon.Visible"), Boolean)
        '
        'lblTitle
        '
        Me.lblTitle.AccessibleDescription = CType(resources.GetObject("lblTitle.AccessibleDescription"), String)
        Me.lblTitle.AccessibleName = CType(resources.GetObject("lblTitle.AccessibleName"), String)
        Me.lblTitle.Anchor = CType(resources.GetObject("lblTitle.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = CType(resources.GetObject("lblTitle.AutoSize"), Boolean)
        Me.lblTitle.Dock = CType(resources.GetObject("lblTitle.Dock"), System.Windows.Forms.DockStyle)
        Me.lblTitle.Enabled = CType(resources.GetObject("lblTitle.Enabled"), Boolean)
        Me.lblTitle.Font = CType(resources.GetObject("lblTitle.Font"), System.Drawing.Font)
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.ImageAlign = CType(resources.GetObject("lblTitle.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblTitle.ImageIndex = CType(resources.GetObject("lblTitle.ImageIndex"), Integer)
        Me.lblTitle.ImeMode = CType(resources.GetObject("lblTitle.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblTitle.Location = CType(resources.GetObject("lblTitle.Location"), System.Drawing.Point)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = CType(resources.GetObject("lblTitle.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblTitle.Size = CType(resources.GetObject("lblTitle.Size"), System.Drawing.Size)
        Me.lblTitle.TabIndex = CType(resources.GetObject("lblTitle.TabIndex"), Integer)
        Me.lblTitle.Text = resources.GetString("lblTitle.Text")
        Me.lblTitle.TextAlign = CType(resources.GetObject("lblTitle.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblTitle.Visible = CType(resources.GetObject("lblTitle.Visible"), Boolean)
        '
        'lblVersion
        '
        Me.lblVersion.AccessibleDescription = CType(resources.GetObject("lblVersion.AccessibleDescription"), String)
        Me.lblVersion.AccessibleName = CType(resources.GetObject("lblVersion.AccessibleName"), String)
        Me.lblVersion.Anchor = CType(resources.GetObject("lblVersion.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = CType(resources.GetObject("lblVersion.AutoSize"), Boolean)
        Me.lblVersion.Dock = CType(resources.GetObject("lblVersion.Dock"), System.Windows.Forms.DockStyle)
        Me.lblVersion.Enabled = CType(resources.GetObject("lblVersion.Enabled"), Boolean)
        Me.lblVersion.Font = CType(resources.GetObject("lblVersion.Font"), System.Drawing.Font)
        Me.lblVersion.Image = CType(resources.GetObject("lblVersion.Image"), System.Drawing.Image)
        Me.lblVersion.ImageAlign = CType(resources.GetObject("lblVersion.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblVersion.ImageIndex = CType(resources.GetObject("lblVersion.ImageIndex"), Integer)
        Me.lblVersion.ImeMode = CType(resources.GetObject("lblVersion.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblVersion.Location = CType(resources.GetObject("lblVersion.Location"), System.Drawing.Point)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = CType(resources.GetObject("lblVersion.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblVersion.Size = CType(resources.GetObject("lblVersion.Size"), System.Drawing.Size)
        Me.lblVersion.TabIndex = CType(resources.GetObject("lblVersion.TabIndex"), Integer)
        Me.lblVersion.Text = resources.GetString("lblVersion.Text")
        Me.lblVersion.TextAlign = CType(resources.GetObject("lblVersion.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblVersion.Visible = CType(resources.GetObject("lblVersion.Visible"), Boolean)
        '
        'lblDescription
        '
        Me.lblDescription.AccessibleDescription = CType(resources.GetObject("lblDescription.AccessibleDescription"), String)
        Me.lblDescription.AccessibleName = CType(resources.GetObject("lblDescription.AccessibleName"), String)
        Me.lblDescription.Anchor = CType(resources.GetObject("lblDescription.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = CType(resources.GetObject("lblDescription.AutoSize"), Boolean)
        Me.lblDescription.Dock = CType(resources.GetObject("lblDescription.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDescription.Enabled = CType(resources.GetObject("lblDescription.Enabled"), Boolean)
        Me.lblDescription.Font = CType(resources.GetObject("lblDescription.Font"), System.Drawing.Font)
        Me.lblDescription.Image = CType(resources.GetObject("lblDescription.Image"), System.Drawing.Image)
        Me.lblDescription.ImageAlign = CType(resources.GetObject("lblDescription.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDescription.ImageIndex = CType(resources.GetObject("lblDescription.ImageIndex"), Integer)
        Me.lblDescription.ImeMode = CType(resources.GetObject("lblDescription.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDescription.Location = CType(resources.GetObject("lblDescription.Location"), System.Drawing.Point)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = CType(resources.GetObject("lblDescription.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDescription.Size = CType(resources.GetObject("lblDescription.Size"), System.Drawing.Size)
        Me.lblDescription.TabIndex = CType(resources.GetObject("lblDescription.TabIndex"), Integer)
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        Me.lblDescription.TextAlign = CType(resources.GetObject("lblDescription.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDescription.Visible = CType(resources.GetObject("lblDescription.Visible"), Boolean)
        '
        'cmdOK
        '
        Me.cmdOK.AccessibleDescription = CType(resources.GetObject("cmdOK.AccessibleDescription"), String)
        Me.cmdOK.AccessibleName = CType(resources.GetObject("cmdOK.AccessibleName"), String)
        Me.cmdOK.Anchor = CType(resources.GetObject("cmdOK.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.BackgroundImage = CType(resources.GetObject("cmdOK.BackgroundImage"), System.Drawing.Image)
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Dock = CType(resources.GetObject("cmdOK.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdOK.Enabled = CType(resources.GetObject("cmdOK.Enabled"), Boolean)
        Me.cmdOK.FlatStyle = CType(resources.GetObject("cmdOK.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdOK.Font = CType(resources.GetObject("cmdOK.Font"), System.Drawing.Font)
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.ImageAlign = CType(resources.GetObject("cmdOK.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdOK.ImageIndex = CType(resources.GetObject("cmdOK.ImageIndex"), Integer)
        Me.cmdOK.ImeMode = CType(resources.GetObject("cmdOK.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdOK.Location = CType(resources.GetObject("cmdOK.Location"), System.Drawing.Point)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = CType(resources.GetObject("cmdOK.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdOK.Size = CType(resources.GetObject("cmdOK.Size"), System.Drawing.Size)
        Me.cmdOK.TabIndex = CType(resources.GetObject("cmdOK.TabIndex"), Integer)
        Me.cmdOK.Text = resources.GetString("cmdOK.Text")
        Me.cmdOK.TextAlign = CType(resources.GetObject("cmdOK.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdOK.Visible = CType(resources.GetObject("cmdOK.Visible"), Boolean)
        '
        'lblCopyright
        '
        Me.lblCopyright.AccessibleDescription = CType(resources.GetObject("lblCopyright.AccessibleDescription"), String)
        Me.lblCopyright.AccessibleName = CType(resources.GetObject("lblCopyright.AccessibleName"), String)
        Me.lblCopyright.Anchor = CType(resources.GetObject("lblCopyright.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.AutoSize = CType(resources.GetObject("lblCopyright.AutoSize"), Boolean)
        Me.lblCopyright.Dock = CType(resources.GetObject("lblCopyright.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCopyright.Enabled = CType(resources.GetObject("lblCopyright.Enabled"), Boolean)
        Me.lblCopyright.Font = CType(resources.GetObject("lblCopyright.Font"), System.Drawing.Font)
        Me.lblCopyright.Image = CType(resources.GetObject("lblCopyright.Image"), System.Drawing.Image)
        Me.lblCopyright.ImageAlign = CType(resources.GetObject("lblCopyright.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCopyright.ImageIndex = CType(resources.GetObject("lblCopyright.ImageIndex"), Integer)
        Me.lblCopyright.ImeMode = CType(resources.GetObject("lblCopyright.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCopyright.Location = CType(resources.GetObject("lblCopyright.Location"), System.Drawing.Point)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.RightToLeft = CType(resources.GetObject("lblCopyright.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblCopyright.Size = CType(resources.GetObject("lblCopyright.Size"), System.Drawing.Size)
        Me.lblCopyright.TabIndex = CType(resources.GetObject("lblCopyright.TabIndex"), Integer)
        Me.lblCopyright.Text = resources.GetString("lblCopyright.Text")
        Me.lblCopyright.TextAlign = CType(resources.GetObject("lblCopyright.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblCopyright.Visible = CType(resources.GetObject("lblCopyright.Visible"), Boolean)
        '
        'lblCodebase
        '
        Me.lblCodebase.AccessibleDescription = CType(resources.GetObject("lblCodebase.AccessibleDescription"), String)
        Me.lblCodebase.AccessibleName = CType(resources.GetObject("lblCodebase.AccessibleName"), String)
        Me.lblCodebase.Anchor = CType(resources.GetObject("lblCodebase.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCodebase.AutoSize = CType(resources.GetObject("lblCodebase.AutoSize"), Boolean)
        Me.lblCodebase.Dock = CType(resources.GetObject("lblCodebase.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCodebase.Enabled = CType(resources.GetObject("lblCodebase.Enabled"), Boolean)
        Me.lblCodebase.Font = CType(resources.GetObject("lblCodebase.Font"), System.Drawing.Font)
        Me.lblCodebase.Image = CType(resources.GetObject("lblCodebase.Image"), System.Drawing.Image)
        Me.lblCodebase.ImageAlign = CType(resources.GetObject("lblCodebase.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblCodebase.ImageIndex = CType(resources.GetObject("lblCodebase.ImageIndex"), Integer)
        Me.lblCodebase.ImeMode = CType(resources.GetObject("lblCodebase.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCodebase.Location = CType(resources.GetObject("lblCodebase.Location"), System.Drawing.Point)
        Me.lblCodebase.Name = "lblCodebase"
        Me.lblCodebase.RightToLeft = CType(resources.GetObject("lblCodebase.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblCodebase.Size = CType(resources.GetObject("lblCodebase.Size"), System.Drawing.Size)
        Me.lblCodebase.TabIndex = CType(resources.GetObject("lblCodebase.TabIndex"), Integer)
        Me.lblCodebase.Text = resources.GetString("lblCodebase.Text")
        Me.lblCodebase.TextAlign = CType(resources.GetObject("lblCodebase.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblCodebase.Visible = CType(resources.GetObject("lblCodebase.Visible"), Boolean)
        '
        'frmAbout
        '
        Me.AcceptButton = Me.cmdOK
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.cmdOK
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCodebase, Me.lblCopyright, Me.cmdOK, Me.lblDescription, Me.lblVersion, Me.lblTitle, Me.pbIcon})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmAbout"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

	' Note: Because this form is opened by frmMain using the ShowDialog command, we simply set the
	' DialogResult property of cmdOK to OK which causes the form to close when clicked.
	Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Try
			' Set this Form's Text & Icon properties by using values from the parent form
			Me.Text = "About " & Me.Owner.Text
			Me.Icon = Me.Owner.Icon

			' Set this Form's Picture Box's image using the parent's icon 
			' However, we need to convert it to a Bitmap since the Picture Box Control
			' will not accept a raw Icon.
			Me.pbIcon.Image = Me.Owner.Icon.ToBitmap()

			' Set the labels identitying the Title, Version, and Description by
			' reading Assembly meta-data originally entered in the AssemblyInfo.vb file
			' using the AssemblyInfo class defined in the same file
			Dim ainfo As New AssemblyInfo()

			Me.lblTitle.Text = ainfo.Title
			Me.lblVersion.Text = String.Format("Version {0}", ainfo.Version)
			Me.lblCopyright.Text = ainfo.Copyright
			Me.lblDescription.Text = ainfo.Description
			Me.lblCodebase.Text = ainfo.CodeBase

		Catch exp As System.Exception
			' This catch will trap any unexpected error.
			MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)

		End Try
	End Sub


End Class
