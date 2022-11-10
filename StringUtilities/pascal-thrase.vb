'#Language "WWB-COM"

Sub Main
	Dim result As String 'a variable to store the final result
	Dim dictationAsArray() As String 'an array which will hold the dictation as a collection of strings

	'ListVar1 stores what we have just dictated as a string
	'so use split function to separate all of the individual words into an array
	dictationAsArray = Split(ListVar1, " ")

	'loop through all of the words, capitalising the first letter, and appending to the result
	For i = 0 To UBound(dictationAsArray)
		
		Dim currentWord As String

		currentWord = dictationAsArray(i)

		currentWord = UCase(Left(currentWord, 1)) & Mid(currentWord, 2)

		result += currentWord
	Next

	'output the result
	SendDragonKeys result
End Sub
