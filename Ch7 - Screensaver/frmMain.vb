'Copyright (C) 2002 Microsoft Corporation
'All rights reserved.
'THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
'EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
'MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

'Requires the Trial or Release version of Visual Studio .NET Professional (or greater).

Option Strict On

Imports System.IO

Public Class frmMain
	Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

		' So that we only need to set the title of the application once,
		' we use the AssemblyInfo class (defined in the AssemblyInfo.vb file)
		' to read the AssemblyTitle attribute.
		Dim ainfo As New AssemblyInfo()

		Me.Text = ainfo.Title
		Me.mnuAbout.Text = String.Format("&About {0} ...", ainfo.Title)

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
	Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
	Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
	Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
	Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
	Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuHelp})
        Me.mnuMain.RightToLeft = CType(resources.GetObject("mnuMain.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'mnuFile
        '
        Me.mnuFile.Enabled = CType(resources.GetObject("mnuFile.Enabled"), Boolean)
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Shortcut = CType(resources.GetObject("mnuFile.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFile.ShowShortcut = CType(resources.GetObject("mnuFile.ShowShortcut"), Boolean)
        Me.mnuFile.Text = resources.GetString("mnuFile.Text")
        Me.mnuFile.Visible = CType(resources.GetObject("mnuFile.Visible"), Boolean)
        '
        'mnuExit
        '
        Me.mnuExit.Enabled = CType(resources.GetObject("mnuExit.Enabled"), Boolean)
        Me.mnuExit.Index = 0
        Me.mnuExit.Shortcut = CType(resources.GetObject("mnuExit.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuExit.ShowShortcut = CType(resources.GetObject("mnuExit.ShowShortcut"), Boolean)
        Me.mnuExit.Text = resources.GetString("mnuExit.Text")
        Me.mnuExit.Visible = CType(resources.GetObject("mnuExit.Visible"), Boolean)
        '
        'mnuHelp
        '
        Me.mnuHelp.Enabled = CType(resources.GetObject("mnuHelp.Enabled"), Boolean)
        Me.mnuHelp.Index = 1
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout})
        Me.mnuHelp.Shortcut = CType(resources.GetObject("mnuHelp.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelp.ShowShortcut = CType(resources.GetObject("mnuHelp.ShowShortcut"), Boolean)
        Me.mnuHelp.Text = resources.GetString("mnuHelp.Text")
        Me.mnuHelp.Visible = CType(resources.GetObject("mnuHelp.Visible"), Boolean)
        '
        'mnuAbout
        '
        Me.mnuAbout.Enabled = CType(resources.GetObject("mnuAbout.Enabled"), Boolean)
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Shortcut = CType(resources.GetObject("mnuAbout.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuAbout.ShowShortcut = CType(resources.GetObject("mnuAbout.ShowShortcut"), Boolean)
        Me.mnuAbout.Text = resources.GetString("mnuAbout.Text")
        Me.mnuAbout.Visible = CType(resources.GetObject("mnuAbout.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = CType(resources.GetObject("Label1.AccessibleDescription"), String)
        Me.Label1.AccessibleName = CType(resources.GetObject("Label1.AccessibleName"), String)
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
        'btnInstall
        '
        Me.btnInstall.AccessibleDescription = resources.GetString("btnInstall.AccessibleDescription")
        Me.btnInstall.AccessibleName = resources.GetString("btnInstall.AccessibleName")
        Me.btnInstall.Anchor = CType(resources.GetObject("btnInstall.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnInstall.BackgroundImage = CType(resources.GetObject("btnInstall.BackgroundImage"), System.Drawing.Image)
        Me.btnInstall.Dock = CType(resources.GetObject("btnInstall.Dock"), System.Windows.Forms.DockStyle)
        Me.btnInstall.Enabled = CType(resources.GetObject("btnInstall.Enabled"), Boolean)
        Me.btnInstall.FlatStyle = CType(resources.GetObject("btnInstall.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnInstall.Font = CType(resources.GetObject("btnInstall.Font"), System.Drawing.Font)
        Me.btnInstall.Image = CType(resources.GetObject("btnInstall.Image"), System.Drawing.Image)
        Me.btnInstall.ImageAlign = CType(resources.GetObject("btnInstall.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnInstall.ImageIndex = CType(resources.GetObject("btnInstall.ImageIndex"), Integer)
        Me.btnInstall.ImeMode = CType(resources.GetObject("btnInstall.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnInstall.Location = CType(resources.GetObject("btnInstall.Location"), System.Drawing.Point)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.RightToLeft = CType(resources.GetObject("btnInstall.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnInstall.Size = CType(resources.GetObject("btnInstall.Size"), System.Drawing.Size)
        Me.btnInstall.TabIndex = CType(resources.GetObject("btnInstall.TabIndex"), Integer)
        Me.btnInstall.Text = resources.GetString("btnInstall.Text")
        Me.btnInstall.TextAlign = CType(resources.GetObject("btnInstall.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnInstall.Visible = CType(resources.GetObject("btnInstall.Visible"), Boolean)
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = resources.GetString("btnClose.AccessibleDescription")
        Me.btnClose.AccessibleName = resources.GetString("btnClose.AccessibleName")
        Me.btnClose.Anchor = CType(resources.GetObject("btnClose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Dock = CType(resources.GetObject("btnClose.Dock"), System.Windows.Forms.DockStyle)
        Me.btnClose.Enabled = CType(resources.GetObject("btnClose.Enabled"), Boolean)
        Me.btnClose.FlatStyle = CType(resources.GetObject("btnClose.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnClose.Font = CType(resources.GetObject("btnClose.Font"), System.Drawing.Font)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = CType(resources.GetObject("btnClose.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.ImageIndex = CType(resources.GetObject("btnClose.ImageIndex"), Integer)
        Me.btnClose.ImeMode = CType(resources.GetObject("btnClose.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnClose.Location = CType(resources.GetObject("btnClose.Location"), System.Drawing.Point)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = CType(resources.GetObject("btnClose.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnClose.Size = CType(resources.GetObject("btnClose.Size"), System.Drawing.Size)
        Me.btnClose.TabIndex = CType(resources.GetObject("btnClose.TabIndex"), Integer)
        Me.btnClose.Text = resources.GetString("btnClose.Text")
        Me.btnClose.TextAlign = CType(resources.GetObject("btnClose.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnClose.Visible = CType(resources.GetObject("btnClose.Visible"), Boolean)
        '
        'frmMain
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnInstall, Me.Label1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.mnuMain
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmMain"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Standard Menu Code "
	' <System.Diagnostics.DebuggerStepThrough()> has been added to some procedures since they are
	' not the focus of the demo. Remove them if you wish to debug the procedures.
	' This code simply shows the About form.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
		' Open the About form in Dialog Mode
		Dim frm As New frmAbout()
		frm.ShowDialog(Me)
		frm.Dispose()
	End Sub

	' This code will close the form.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
		' Close the current form
		Me.Close()
	End Sub
#End Region

    ' This button closes the application
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    ' This button installs the demo screen saver on your machine by copying
    '   the SCR file to your Windows System directory.
    Private Sub btnInstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstall.Click

        Dim fileName As String = "VB_NET How-To ScreenSaver.scr"
        Dim sourceFile As String = Environment.CurrentDirectory & "\..\" & fileName
        Dim destFile As String = Environment.SystemDirectory & "\" & fileName

        ' Try to install the screen saver. If not successful, then show
        '   the error to the user.
        Try
            File.Copy(sourceFile, destFile, True)
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation, Me.Text)
        End Try


    End Sub


End Class