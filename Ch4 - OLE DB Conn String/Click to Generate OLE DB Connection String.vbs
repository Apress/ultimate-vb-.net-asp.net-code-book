Dim objDataLinks, strRetVal
Set objDataLinks = CreateObject("DataLinks")
On Error Resume Next ' ignore cancel
strRetVal = objDataLinks.PromptNew
On Error Goto 0
If Not IsEmpty(strRetVal) Then
InputBox "Your Connection String is listed below.", _
    "OLE DB Connection String", strRetVal
End If
Set objDataLinks = Nothing
