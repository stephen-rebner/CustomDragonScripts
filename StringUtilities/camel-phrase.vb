'#Language "WWB-COM"

Sub Main
	Dim result As String 'a variable to store the final result
	Dim dictationAsArray() As String 'an array which will hold the dictation as a collection of strings

	'ListVar1 stores what we have just dictated as a string
	'so use split function to separate all of the individual words into an array
	dictationAsArray = Split(ListVar1, " ")

	'loop through all of the words. Ensure that the first word is lowercase. The rest of the words should be uppercase
	For i = 0 To UBound(dictationAsArray)
		
		Dim currentWord As String

		currentWord = dictationAsArray(i)
		
		'replace all hyphens and apostrophes from the string
		currentWord = Replace(currentWord, "-", "")
		currentWord = Replace(currentWord, "'", "")
		
		If i = 0 Then
			currentWord = LCase(Left(currentWord, 1)) & Mid(currentWord, 2)
		Else
			currentWord = UCase(Left(currentWord, 1)) & Mid(currentWord, 2)
		End If

		result += currentWord
	Next

	'output the result
	SendDragonKeys result
End Sub
