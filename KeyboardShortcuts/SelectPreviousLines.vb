'#Language "WWB-COM"

'The command name is: grab previous <number> lines
Sub Main
	Dim numberOfTimesToExecuteString As String
	Dim numberOfTimesToExecute As Integer
	
	'UtilityProvider.ContextValue is a Dragon Function
	'That enables us to get the dictation value for the number of lines we wish to select
	numberOfTimesToExecuteString = UtilityProvider.ContextValue (0)
	numberOfTimesToExecute = CInt(numberOfTimesToExecuteString)
	
	' Pressing the end button takes us to the end of the line
	' pressing shift+home selects the whole of the first line
	SendDragonKeys "{End}{Shift+Home}"
	
	' We have already selected the first line with the command above
	'for that reason, don't select any more lines if the spoken command
	'has only requested one line be selected
	If numberOfTimesToExecute > 1 Then
	
	'Since we have already selected one line, subtract that from the amount of times we Execute
	'Shift+Up
	numberOfTimesToExecute = numberOfTimesToExecute -1
	
	' Pressing shift+up selects the next line up
	'We then also pass on the amount of times we want to execute this command (numberOfTimesToExecuteString)
	SendDragonKeys "{Shift+Up " & numberOfTimesToExecute & "}{Shift+Home}"
	
	End If
	
End Sub
