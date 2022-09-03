'#Language "WWB-COM"

Sub Main
	Dim numberOfTimesToExecute As String
	
	numberOfTimesToExecute = UtilityProvider.ContextValue (0)
	
	Select Case numberOfTimesToExecute
		Case "one"
			numberOfTimesToExecute = "1"
		Case "two"
			numberOfTimesToExecute = "2"
		Case "three"
			numberOfTimesToExecute = "3"
		Case "four"
			numberOfTimesToExecute = "4"
		Case "five"
			numberOfTimesToExecute = "5"
		Case "six"
			numberOfTimesToExecute = "6"
		Case "seven"
			numberOfTimesToExecute = "7"					
		Case "eight"
			numberOfTimesToExecute = "8"
		Case "nine"
			numberOfTimesToExecute = "9"
		Case "ten"
			numberOfTimesToExecute = "10"
	End Select

	SendDragonKeys "{shift+tab " & numberOfTimesToExecute & "}"
End Sub
