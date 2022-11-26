Declare Function keybd_event Lib "user32.dll" (ByVal vKey As _
Long, bScan As Long, ByVal Flag As Long, ByVal exInfo As Long) As Long

Const VK_ALT = 18

Sub Main
	SendDragonKeys "{Enter}"
    Wait 0.1
	keybd_event(VK_ALT,0,2,0)  'Releases the Alt Key
End Sub
