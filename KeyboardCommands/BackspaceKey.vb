'#Language "WWB-COM

'The command is spoken as: "Backspace key <number of times to execute>"
' This allows the Backspace key to be pressed more than once, which is not allowed out of the box on Dragon
Sub Main
 SendDragonKeys "{BackSpace " & ListVar1 & "}"
End Sub

