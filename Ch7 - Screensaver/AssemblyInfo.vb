'Copyright (C) 2002 Microsoft Corporation
'All rights reserved.
'THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
'EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
'MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

'Requires the Trial or Release version of Visual Studio .NET Professional (or greater).

Option Strict On

Imports System.Reflection

<Assembly: AssemblyTitle("VB.NET How-To: Creating a Screensaver Using GDI+")> 
<Assembly: AssemblyDescription("Microsoft Visual Basic .NET How-To: Creating a Screensaver Using GDI+")> 
<Assembly: AssemblyCompany("Microsoft Corporation")> 
<Assembly: AssemblyProduct("Microsoft Visual Basic .NET How To: 2002")> 
<Assembly: AssemblyCopyright("Copyright © 2002 Microsoft Corporation.  All rights reserved.")> 
<Assembly: CLSCompliant(True)> 

<Assembly: AssemblyVersion("1.0.0.0")> 

#Region " Helper Class to Get Information for the About form. "
' This class uses the System.Reflection.Assembly class to
' access assembly meta-data
' This class is not a normal feature of AssemblyInfo.vb
Public Class AssemblyInfo
	' Used by Helper Functions to access information from Assembly Attributes
	Private myType As Type

	Public Sub New()
		myType = GetType(frmMain)
	End Sub

	Public ReadOnly Property AsmName() As String
		Get
			Return myType.Assembly.GetName.Name.ToString()
		End Get
	End Property
	Public ReadOnly Property AsmFQName() As String
		Get
			Return myType.Assembly.GetName.FullName.ToString()
		End Get
	End Property
	Public ReadOnly Property CodeBase() As String
		Get
			Return myType.Assembly.CodeBase
		End Get
	End Property
	Public ReadOnly Property Copyright() As String
		Get
            Dim at As Type = GetType(AssemblyCopyrightAttribute)
			Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
			Dim ct As AssemblyCopyrightAttribute = CType(r(0), AssemblyCopyrightAttribute)
			Return ct.Copyright
		End Get
	End Property
	Public ReadOnly Property Company() As String
		Get
			Dim at As Type = GetType(AssemblyCopyrightAttribute)
			Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
			Dim ct As AssemblyCompanyAttribute = CType(r(0), AssemblyCompanyAttribute)
			Return ct.Company
		End Get
	End Property
	Public ReadOnly Property Description() As String
		Get
			Dim at As Type = GetType(AssemblyDescriptionAttribute)
			Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
			Dim da As AssemblyDescriptionAttribute = CType(r(0), AssemblyDescriptionAttribute)
			Return da.Description
		End Get
	End Property
	Public ReadOnly Property Product() As String
		Get
			Dim at As Type = GetType(AssemblyProductAttribute)
			Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
			Dim pt As AssemblyProductAttribute = CType(r(0), AssemblyProductAttribute)
			Return pt.Product
		End Get
	End Property
	Public ReadOnly Property Title() As String
		Get
			Dim at As Type = GetType(AssemblyTitleAttribute)
			Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
			Dim ta As AssemblyTitleAttribute = CType(r(0), AssemblyTitleAttribute)
			Return ta.Title
		End Get
	End Property
	Public ReadOnly Property Version() As String
		Get
			Return myType.Assembly.GetName.Version.ToString()
		End Get
	End Property
End Class

#End Region