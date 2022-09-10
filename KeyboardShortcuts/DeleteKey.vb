'#Language "WWB-COM

'The command is spoken as: "Delete key <number of times to execute>"
' This allows the Delete key to be pressed more than once, which is not allowed out of the box on Dragon
Sub Main
 SendDragonKeys "{Del " & ListVar1 & "}"
End Sub
