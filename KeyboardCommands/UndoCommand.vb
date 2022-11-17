'#Language "WWB-COM

'The command is spoken as: "undo key <number of times to execute>"
' This allows the control Z key to be pressed more than once, which is not allowed out of the box on Dragon
Sub Main
 SendDragonKeys "{Ctrl+z " & ListVar1 & "}"	
End Sub
