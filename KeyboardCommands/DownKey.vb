'#Language "WWB-COM

' The command below is faster than the inbuilt function for pressing the down key
'The command is spoken as: "Down key <number of times to execute>"
Sub Main
 SendDragonKeys "{Down " & ListVar1 & "}"	
End Sub
