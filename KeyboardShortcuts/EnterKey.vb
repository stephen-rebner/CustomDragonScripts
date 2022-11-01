'#Language "WWB-COM

'The command is spoken as: "Enter key <number of times to execute>"
' This allows the Enter key to be pressed more than once, which is not allowed out of the box on Dragon
Sub Main
 SendDragonKeys "{Enter " & ListVar1 & "}"
End Sub
