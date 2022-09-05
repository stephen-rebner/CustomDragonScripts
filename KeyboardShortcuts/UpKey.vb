'#Language "WWB-COM"

Option Explicit

' The command below is faster than the inbuilt function for pressing the down key
'The command is spoken as: "Up key <number of times to execute>"
Sub Main
 SendDragonKeys "{Up " & ListVar1 & "}"	
End Sub
