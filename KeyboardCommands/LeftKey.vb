'#Language "WWB-COM

' The command below is faster than the inbuilt function for pressing the down key
'The command is spoken as: "Left key <number of times to execute>"
Sub Main
 SendDragonKeys "{Left " & ListVar1 & "}"
End Sub
